using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lead.Tool.ProjectPath;
using log4net;
using log4net.Core;
using System.Threading;
using System.Windows.Forms;
using Lead.Tool.Excel;
using System.Diagnostics;

namespace Lead.Tool.Log
{
    public class ShowFormParam
    {
        public FormMode Mode { get; set; }
        public ShowForm ProblemForm { get; set; }
        public ProcessBar ProcessBarForm { get; set; }
        public TickTipForm TickTipForm { get; set; }
        public bool IsNeedShow { get; set; }
        public string Mes { get; set; }
        public string Solution { get; set; }
        public int Seconds { get; set; }
    }
    public enum LogLevel
    {
        OK = 1,
        Info = 2,
        Warn,
        Error,
        Fatal,
    }

    public enum FormMode
    {
        TipsForm = 1,
        ProcessBar = 2,
        TickTipsForm = 3,
    }

    public static class Logger
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger("log");
        private static string path = PathManager.ConfigPath + @"\Bin\log.config";
        private static bool _isOn = true;
        private static List<object> RemoveKey = new List<object>();
        private static Dictionary<object, ShowFormParam> _DicShowForm = new Dictionary<object, ShowFormParam>();
        private static Thread Time  = new Thread(timer2_Tick);
        private static object locker = new object();
        private static RealTime _ReadlUI = new RealTime();
        private static string ErrorPath = @"D:\错误记录\";
        private static string LastOK = "";
        private static string LastInfo = "";
        private static string LastWarn = "";
        private static string LastError = "";
        private static string LastFatal = "";
        private static Dictionary<string, DateTime> _History = new Dictionary<string, DateTime>();


        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(path));
            Time.Start();
            if (!Directory.Exists(ErrorPath))
            {
                Directory.CreateDirectory(ErrorPath);
            }
        }

        public static Control ReadlUI
        {
            get { return _ReadlUI; }
        }

        public static bool IsShowMethod
        {
            get { return _isOn; }
            set { _isOn = value; }
        }

        private static void Stack(ref string Mes,bool ON)
        {
            try
            {
                if (ON)
                {
                    System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
                    System.Diagnostics.StackFrame[] sfs = st.GetFrames();

                    string _fullName = string.Empty, _methodName = string.Empty;

                    _methodName = sfs[2].GetMethod().Name;
                    var x1 = sfs[2].GetMethod().DeclaringType.Namespace;

                    Mes = "[" + x1 + "]." + "[" + _methodName + "]" + " " + Mes;
                }
            }
            catch (Exception ex)
            {
                _log.Error("Logger记录堆栈信息失败:"+ex.Message);
            }
        }

        public static void OK(string mes)
        {
            if (!_History.ContainsKey(mes))
            {
                _History.Add(mes, DateTime.Now);
            }
            else
            {
                if ((DateTime.Now - _History[mes]).TotalSeconds < 10)
                {
                    return;
                }
            }

            if (_History.ContainsKey(mes))
            {
                _History[mes] = DateTime.Now;
            }

            //if(mes != LastOK)
            {
                LastOK = mes;

                Stack(ref mes, _isOn);
                _log.Info(mes);

                Action<int> ac = (x) => { _ReadlUI.Add(LogLevel.OK, DateTime.Now.ToString("yy/MM/dd-HH:mm:ss:fff"), x, mes + "\r\n"); };
                ac.BeginInvoke(Thread.CurrentThread.ManagedThreadId, null, null);
            }
        }

        public static void Info(string mes)
        {
            //if (mes != LastInfo)
            {
                LastInfo = mes;

                Stack(ref mes, _isOn);
                _log.Info(mes);

                return;
                Action<int> ac = (x) => { _ReadlUI.Add(LogLevel.Info, DateTime.Now.ToString("yy/MM/dd-HH:mm:ss:fff"), x, mes + "\r\n"); };
                ac.BeginInvoke(Thread.CurrentThread.ManagedThreadId, null, null);
            }
        }

        public static void Warn(string mes,string Solution="NA")
        {
            if (!_History.ContainsKey(mes))
            {
                _History.Add(mes, DateTime.Now);
            }
            else
            {
                if ((DateTime.Now - _History[mes]).TotalSeconds < 10)
                {
                    return;
                }
            }

            if (_History.ContainsKey(mes))
            {
                _History[mes]= DateTime.Now;
            }

            //if (mes != LastWarn)
            {
                LastWarn = mes;

                Stack(ref mes, _isOn);
                _log.Warn(mes);

                //string PathDay = ErrorPath + DateTime.Now.ToString("yy_MM_dd") + ".txt";
                //File.AppendAllText(PathDay, mes + "\r\n");

                Action<int> ac = (x) => { _ReadlUI.Add(LogLevel.Warn, DateTime.Now.ToString("yy/MM/dd-HH:mm:ss:fff"), x, mes + "\r\n"); };
                ac.BeginInvoke(Thread.CurrentThread.ManagedThreadId, null, null);
            }
        }

        public static void Error(string mes, string Solution = "NA")
        {
            if (!_History.ContainsKey(mes))
            {
                _History.Add(mes, DateTime.Now);
            }
            else
            {
                if ((DateTime.Now - _History[mes]).TotalSeconds < 10)
                {
                    return;
                }
            }
            if (_History.ContainsKey(mes))
            {
                _History[mes] = DateTime.Now;
            }

            //if (mes != LastError)
            {
                LastError = mes;

                Stack(ref mes, _isOn);
                _log.Error(mes);

                Action<int> ac = (x) => { _ReadlUI.Add(LogLevel.Error, DateTime.Now.ToString("yy/MM/dd-HH:mm:ss:fff"), x, mes + "\r\n"); };
                ac.BeginInvoke(Thread.CurrentThread.ManagedThreadId, null, null); 
            }
        }

        public static void Fatal(string mes, string Solution = "NA")
        {
            if (!_History.ContainsKey(mes))
            {
                _History.Add(mes, DateTime.Now);
            }
            else
            {
                if ((DateTime.Now - _History[mes]).TotalSeconds < 10)
                {
                    return;
                }
            }
            if (_History.ContainsKey(mes))
            {
                _History[mes] = DateTime.Now;
            }

            //if (mes != LastFatal)
            {
                LastFatal = mes;

                Stack(ref mes, _isOn);
                _log.Warn(mes);

                Action<int> ac = (x) => { _ReadlUI.Add(LogLevel.Fatal, DateTime.Now.ToString("yy/MM/dd-HH:mm:ss:fff"), x, mes + "\r\n"); };
                ac.BeginInvoke(Thread.CurrentThread.ManagedThreadId, null, null);
            }
        }
        public static void ShowTickTipsForm(object Key, string Mes, int Second = 0)
        {
            Info("窗口(" + Key + ")" + Mes + "弹出");

            var Mode = FormMode.TickTipsForm;

            lock (locker)
            {
                if (!_DicShowForm.ContainsKey(Key))
                {
                    _DicShowForm.Add(Key, new ShowFormParam()
                    {
                        IsNeedShow = true,
                        Mes = Mes,
                        Solution = "",
                        Mode = Mode,
                        Seconds = Second
                    });
                }
                else
                {
                    _DicShowForm[Key].Mode = Mode;
                    _DicShowForm[Key].Mes = Mes;
                    if (Mode == FormMode.ProcessBar && _DicShowForm[Key].ProcessBarForm == null)
                    {
                        _DicShowForm[Key].IsNeedShow = true;
                    }
                    if (Mode == FormMode.TipsForm && _DicShowForm[Key].ProblemForm == null)
                    {
                        _DicShowForm[Key].IsNeedShow = true;
                    }
                    if (Mode == FormMode.TickTipsForm && _DicShowForm[Key].TickTipForm == null)
                    {
                        _DicShowForm[Key].IsNeedShow = true;
                    }
                }
            }
            Info("窗口(" + Key + ")" + Mes + "关闭");
        }
        public static void ShowForm(object Key, FormMode Mode, string Mes , string Solution="",int Second= 0)
        {
            Info("窗口("+ Key +")"+ Mes+"弹出");
            lock (locker)
            {
                if (!_DicShowForm.ContainsKey(Key))
                {
                    _DicShowForm.Add(Key, new ShowFormParam()
                    {
                        IsNeedShow = true,
                        Mes = Mes,
                        Solution = Solution,
                        Mode = Mode,
                        Seconds = Second
                    });
                }
                else
                {
                    _DicShowForm[Key].Mode = Mode;
                    _DicShowForm[Key].Mes = Mes;
                    if (Mode == FormMode.ProcessBar && _DicShowForm[Key].ProcessBarForm == null)
                    {
                        _DicShowForm[Key].IsNeedShow = true ;
                    }
                    if (Mode == FormMode.TipsForm && _DicShowForm[Key].ProblemForm == null)
                    {
                        _DicShowForm[Key].IsNeedShow = true; 
                    }
                    if (Mode == FormMode.TickTipsForm && _DicShowForm[Key].TickTipForm == null)
                    {
                        _DicShowForm[Key].IsNeedShow = true;
                    }
                }
            }
            Info("窗口(" + Key + ")" + Mes + "关闭");
        }

        public static void CloseForm(object Key)
        {
            lock (locker)
            {
                if (_DicShowForm.ContainsKey(Key))
                {
                    _DicShowForm[Key].IsNeedShow = false;
                }
            }
        }
        public static void FormCloseTime(object Key)
        {
            foreach (var item in _DicShowForm)
            {
                if (item.Key == Key)
                {
                    item.Value.IsNeedShow = false;
                }
            }
        }
        private static void timer2_Tick(object state)
        {
            while (true)
            {
                Thread.Sleep(100);
                Application.DoEvents();

                lock (locker)
                {
                    foreach (var item in RemoveKey)
                    {
                        _DicShowForm.Remove(item);
                    }
                    RemoveKey.Clear();

                    foreach (var item in _DicShowForm)
                    {
                        if (item.Value.IsNeedShow)
                        {
                            lock (locker)
                            {
                                if (item.Value.Mode == FormMode.TipsForm)
                                {
                                    if (item.Value.ProcessBarForm != null)
                                    {
                                        item.Value.ProcessBarForm.Close();
                                        item.Value.ProcessBarForm = null;
                                    }
                                    if (item.Value.TickTipForm != null)
                                    {
                                        item.Value.TickTipForm.Close();
                                        item.Value.TickTipForm = null;
                                    }
                                    if (item.Value.ProblemForm == null )
                                    {
                                        item.Value.ProblemForm = new ShowForm(item.Value.Mes, item.Value.Solution,item.Key);
                                        item.Value.ProblemForm.StartPosition = FormStartPosition.CenterScreen;
                                        item.Value.ProblemForm.TopMost = true;
                                        item.Value.ProblemForm.Show();
                                        item.Value.ProblemForm.FormCloseEvent += new FormClose(FormCloseTime);
                                    }
                                }
                                else if (item.Value.Mode == FormMode.ProcessBar)
                                {
                                    if (item.Value.ProblemForm != null)
                                    {
                                        item.Value.ProblemForm.Close();
                                        item.Value.ProblemForm = null;
                                    }
                                    if (item.Value.TickTipForm != null)
                                    {
                                        item.Value.TickTipForm.Close();
                                        item.Value.TickTipForm = null;
                                    }
                                    if (item.Value.ProcessBarForm == null)
                                    {
                                        item.Value.ProcessBarForm = new ProcessBar(item.Value.Mes);
                                        item.Value.ProcessBarForm.StartPosition = FormStartPosition.CenterScreen;
                                        item.Value.ProcessBarForm.TopMost = true;
                                        item.Value.ProcessBarForm.Show();
                                    }
                                }
                                else if (item.Value.Mode == FormMode.TickTipsForm)
                                {
                                    if (item.Value.ProcessBarForm != null)
                                    {
                                        item.Value.ProcessBarForm.Close();
                                        item.Value.ProcessBarForm = null;
                                    }
                                    if (item.Value.ProblemForm != null)
                                    {
                                        item.Value.ProblemForm.Close();
                                        item.Value.ProblemForm = null;
                                    }
                                    if (item.Value.TickTipForm == null)
                                    {
                                        item.Value.TickTipForm = new TickTipForm(item.Value.Mes, item.Value.Seconds, item.Key);
                                        item.Value.TickTipForm.StartPosition = FormStartPosition.CenterScreen;
                                        item.Value.TickTipForm.TopMost = true;
                                        item.Value.TickTipForm.Show();
                                        item.Value.TickTipForm.FormCloseEvent += new FormClose(FormCloseTime);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (item.Value.ProblemForm != null && item.Value.Mode == FormMode.TipsForm)
                            {
                                item.Value.ProblemForm.Close();
                                item.Value.ProblemForm = null;
                                RemoveKey.Add(item.Key);
                            }
                            else if (item.Value.ProcessBarForm != null && item.Value.Mode == FormMode.ProcessBar)
                            {
                                item.Value.ProcessBarForm.Close();
                                item.Value.ProcessBarForm = null;
                                RemoveKey.Add(item.Key);
                            }
                            else if (item.Value.TickTipForm != null && item.Value.Mode == FormMode.TickTipsForm)
                            {
                                item.Value.TickTipForm.Close();
                                item.Value.TickTipForm = null;
                                RemoveKey.Add(item.Key);
                            }
                        }
                    }
                }
            }
        }
    }

}
