using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataGridViewTools;

namespace Lead.Tool.Log
{
    public partial class RealTime : UserControl
    {
        private object OB = new object();
        private BindingList<RealInfo> _Info = new BindingList<RealInfo>();
        public RealTime()
        {
            InitializeComponent();
            DataGridViewToolsClass dg = new DataGridViewToolsClass();
            dg.NoShanSHuo(dataGridView1);
            dg.NoShanSHuo(dataGridView2);

            if (this.dataGridView1.Rows.Count == 0)
            {
                this.dataGridView1.Rows.Add(DateTime.Now.ToString("yy/MM/dd-HH:mm:ss:fff"),LogLevel.OK,"main","界面加载完成！");
                this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Green;
            }

            this.dataGridView1.Visible = true;
            this.dataGridView2.Visible = false;
        }

        public void Add(LogLevel level,string Time,int Id,string Mes)
        {
            try
            {
                Action ac = () =>
                {
                    lock (OB)
                    {
                        if (level != LogLevel.Info)
                        {
                            #region 源码
                            ////if (this.dataGridView1.Rows.Count > 100)
                            ////{
                            ////    this.dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows.Count - 1);
                            ////}

                            //this.dataGridView1.Rows.Insert(0, Time, level.ToString(), Id.ToString(), Mes);

                            //if (level == LogLevel.OK)
                            //{
                            //    this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Green;
                            //}
                            //else if (level == LogLevel.Info)
                            //{
                            //    this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Black;
                            //}
                            //else if (level == LogLevel.Warn)
                            //{
                            //    this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.DarkOrange;
                            //}
                            //else if (level == LogLevel.Error || level == LogLevel.Fatal)
                            //{
                            //    this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Red;
                            //}

                            //this.dataGridView1.Rows[0].Visible = false;
                            //if ((level == LogLevel.OK && OK.Checked) ||
                            //        (level == LogLevel.Info && Info.Checked) ||
                            //        (level == LogLevel.Warn && Warn.Checked) ||
                            //        (level == LogLevel.Error && Error.Checked) ||
                            //        (level == LogLevel.Fatal && Fatal.Checked))
                            //{
                            //    this.dataGridView1.Rows[0].Visible = true;
                            //}
                            #endregion

                            #region 12/19 Victor修改-解决日志首行不显示问题
                            if ((level == LogLevel.OK && OK.Checked) ||
                                    (level == LogLevel.Info && Info.Checked) ||
                                    (level == LogLevel.Warn && Warn.Checked) ||
                                    (level == LogLevel.Error && Error.Checked) ||
                                    (level == LogLevel.Fatal && Fatal.Checked))
                            {
                                this.dataGridView1.Rows.Insert(0, Time, level.ToString(), Id.ToString(), Mes);
                            }

                            if (level == LogLevel.OK)
                            {
                                this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Green;
                            }
                            else if (level == LogLevel.Info)
                            {
                                this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Black;
                            }
                            else if (level == LogLevel.Warn)
                            {
                                this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.DarkOrange;
                            }
                            else if (level == LogLevel.Error || level == LogLevel.Fatal)
                            {
                                this.dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Red;
                            }
                            #endregion
                        }
                        else
                        {
                            #region 源码
                            //if (_Info.Count > 100)
                            //{
                            //    this.dataGridView2.Rows.RemoveAt(this.dataGridView2.Rows.Count - 1);
                            //}
                            #endregion

                            this.dataGridView2.Rows.Insert(0, Time, level.ToString(), Id.ToString(), Mes);
                        }
                    }
                };
                this.BeginInvoke(ac, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            Action<bool, string> ac = (IsShow,Text)=>
            {
                if (Text == "Info")
                {
                    if (IsShow)
                    {
                        OK.Visible = false;
                        Error.Visible = false;
                        Warn.Visible = false;
                        Fatal.Visible = false;
                        this.dataGridView1.Visible = false;
                        this.dataGridView2.Visible = true;
                    }
                    else
                    {
                        OK.Visible = true;
                        Error.Visible = true;
                        Warn.Visible = true;
                        Fatal.Visible = true;
                        this.dataGridView1.Visible = true;
                        this.dataGridView2.Visible = false;
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == Text)
                        {
                            dataGridView1.Rows[i].Visible = IsShow;
                        }
                    }
                }
            };
            this.BeginInvoke(ac, ((CheckBox)sender).Checked, ((CheckBox)sender).Text.Trim());
        }
    }
}
