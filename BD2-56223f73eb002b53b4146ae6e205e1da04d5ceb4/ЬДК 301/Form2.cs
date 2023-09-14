using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЬДК_301
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;

            if (pass =="Admin")
            {
                Form1 frm = new Form1();
                frm.Show();
                frm.button4.Visible = true;
                this.Hide();
            }
            if (pass == "User")
            {

                Form1 frm = new Form1();
                frm.Show();
                frm.button4.Visible = false;
                this.Hide();
            }
        }
    }
}
