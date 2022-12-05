using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lead.Tool.Log
{
    public delegate void FormClose(object Key);

    public partial class TickTipForm : Form
    {
        int Seconds = 36000;
        DateTime Last = DateTime.Now;
        Timer Time = new Timer();
        object Key = "";
        public FormClose FormCloseEvent;

        public TickTipForm(string Tips,int Second, object KeyValue)
        {
            InitializeComponent();

            var Ti = DateTime.Now.ToString("HH:mm:ss  ");
            if (Tips.Contains("成功"))
            {
                this.label1.ForeColor = Color.Green;
            }
            else if (Tips.Contains("失败") || Tips.Contains("出错") || Tips.Contains("错误"))
            {
                this.label1.ForeColor = Color.Red;
            }
            else
            {
                this.label1.ForeColor = Color.YellowGreen;
            }
            this.label1.Text = Ti+Tips;
            if (Second != 0)
            {
                Seconds = Second;
            }
            Last = DateTime.Now;
            Time.Tick += new EventHandler(xx);
            Time.Enabled = true;
            Time.Interval = 100;
            Key = KeyValue;
            Time.Start();
           
        }

        public void xx(object sender, EventArgs e)
        {
            if ( ((DateTime.Now - Last).TotalSeconds) > Seconds )
            {
                if (FormCloseEvent != null)
                {
                    FormCloseEvent(Key);
                    Time.Enabled = false;
                    this.Close();
                }
            }

        }

        private void TickTipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCloseEvent(Key);
        }
    }

}
