using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int count = Convert.ToInt32(textBox2.Text);
            String name = textBox1.Text;

            for (int i = 1; i <= count; i++)
            {
                textBox3.Text += name + "\r\n";
            }


        }
    }
}
