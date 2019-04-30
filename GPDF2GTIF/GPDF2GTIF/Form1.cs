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
        GTranslate translate = new GTranslate();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            translate.CreateDir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            translate.SetfPath(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            translate.SetfName(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            translate.SetfOutputPath(textBox2.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            translate.SetfOutputFilename(textBox4.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog();
            openF.InitialDirectory = @"./Imports";
            openF.RestoreDirectory = true;
            openF.Title = "Browse Files";
            openF.DefaultExt = "pdf";
            openF.CheckFileExists = true;
            openF.CheckPathExists = true;
            DialogResult res = openF.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBox3.Text = System.IO.Path.GetFileName(openF.FileName);
                textBox4.Text = System.IO.Path.GetFileNameWithoutExtension(openF.FileName);
                textBox4.Text = textBox4.Text + ".tif";
                textBox1.Text = System.IO.Path.GetDirectoryName(openF.FileName);
                translate.SetfName(textBox3.Text);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openF = new FolderBrowserDialog();
            openF.ShowNewFolderButton = true;
            DialogResult res = openF.ShowDialog();
            if(res == DialogResult.OK)
            {
                textBox2.Text = openF.SelectedPath;
                Environment.SpecialFolder root = openF.RootFolder;
            }
        }
    }
}
