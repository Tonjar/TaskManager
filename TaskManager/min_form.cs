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
    public partial class min_form : Form
    {
        public min_form()
        {
            InitializeComponent();
        }

        private void min_form_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void show_string(string str,int mode)
        {
            if (mode == 0)
                this.Text = str;
            else
                button1.Text = str;
        }
    }
}
