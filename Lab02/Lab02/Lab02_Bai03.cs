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
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        //int a, b;
        //string tbshow;

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
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "|*.txt";
            save.ShowDialog();
            FileStream fs = new FileStream(save.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);

            string output = "";
            string[] lines = rtbText.Lines;
            for (int i =0; i<lines.Length; i++)
            {
                DataTable dt = new DataTable();
                try
                {
                    double result = Convert.ToDouble(dt.Compute(lines[i], null));
                    output += lines[i] + " = " + result.ToString() + "\n";
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập lại đúng format của biểu thức cần tính!");
                }
            }
            sw.WriteLine(output);
            MessageBox.Show("Saved to: " + save.FileName);
            sw.Close();
        }
    }
}
