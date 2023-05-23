using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai1 : Form
    {
        public Lab01_Bai1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int a, b;
            double s = 0;
            
            try 
            {
                a = int.Parse(Num1.Text);
                b = int.Parse(Num2.Text);
                s = a + b;
                Results.Text = s.ToString();

            }catch(Exception)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (Control text in this.Controls)
            {
                if (text is TextBox)
                    text.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
