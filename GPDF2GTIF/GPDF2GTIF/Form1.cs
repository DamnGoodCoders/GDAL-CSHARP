using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPDF2GTIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.CreateDir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Program.fPath = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Program.fName = textBox3.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Program.fOutputPath = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Program.fOutputFile = textBox4.Text;
        }
    }
}
