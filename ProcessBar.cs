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
    public partial class ProcessBar : Form
    {
        public ProcessBar(string Mes)
        {
            InitializeComponent();

            this.label1.Text = Mes;
            this.progressBar1.Maximum = 100;
            timer1.Enabled = true;
            timer1.Interval = 300;
            this.Text = Mes;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if ((this.progressBar1.Value + 5) <= this.progressBar1.Maximum+1)
            {
                this.progressBar1.Value += 5;
            }
            else
            {
                this.progressBar1.Value = 5;
            }
        }


    }
}
