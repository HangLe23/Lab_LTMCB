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
    public partial class Lab02_Bai02 : Form
    {
        FileStream fs;
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int lineCount = 0, charCount = 0, wordCount = 0;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            open.ShowDialog();
            try
            {
                fs = new FileStream(open.FileName, FileMode.OpenOrCreate);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            rtbText.Text = content;
            charCount = content.Length;
            tbCharacter.Text = charCount.ToString();
            tbFileName.Text = open.SafeFileName.ToString();
            tbURL.Text = open.FileName;
            content = content.Replace("\r\n", "\r");
            lineCount = rtbText.Lines.Count();
            tbLine.Text = lineCount.ToString();
            string[] source = content.Split(new char[] { '.', '!', '?', ' ', ';', ':', ',', '\r', 
                                            '!', '@', '#', '$', '%', '^', '&', '*'},
                                             StringSplitOptions.RemoveEmptyEntries);
            wordCount = source.Count();
            tbWord.Text = wordCount.ToString();
            fs.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control text in this.Controls)
            {
                if (text is TextBox)
                    text.Text = "";
            }
            rtbText.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
