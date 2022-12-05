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
    public partial class ShowForm : Form
    {
        public FormClose FormCloseEvent;
        object _key = "";
        public ShowForm(string mes,string Solution, object key)
        {
            InitializeComponent();
            this.richTextBox1.Clear();
            this.richTextBox1.AppendText(mes);
            this.richTextBoxSolution.Clear();
            this.richTextBoxSolution.AppendText(Solution);
            _key = key;
        }

        private void ShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCloseEvent(_key);
        }
    }
}
