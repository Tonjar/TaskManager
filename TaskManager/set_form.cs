using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class set_form : Form
    {
        public set_form()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            int m = a.Next(10, 1000);
            chart1.Series[0].Points.Add(m);
        }
    }
}
