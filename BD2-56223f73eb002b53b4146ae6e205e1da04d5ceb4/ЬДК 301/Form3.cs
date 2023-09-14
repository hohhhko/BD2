using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЬДК_301
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kakoysegodnyaprazdnik.ru/");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          label1.Text =Convert.ToString(DateTime.Now);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
           frm.label1.Text = Convert.ToString(DateTime.Now);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                BackColor = Color.Blue;
            }
            else
            {
                BackColor = Color.White;
            }
           
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                BackColor = Color.DarkGreen;
            }
            else
            {
                BackColor = Color.White;
            }        
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                BackColor = Color.Aquamarine;
            }
            else
            {
                BackColor = Color.White;
            }        
        }
    }
}
