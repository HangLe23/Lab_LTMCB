using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab02
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            open.ShowDialog();
            FileStream fs = new FileStream(open.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            rtbText.Text = content;
            fs.Close();
           // MessageBox.Show("Path: " + open.FileName);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "|*.txt";
            save.ShowDialog();
            FileStream fs = new FileStream(save.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);
            string content = rtbText.Text.ToUpper();
            sw.Write(content);
            sw.Close();
            MessageBox.Show("Path: " + save.FileName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
