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
    public partial class Lab01_Bai3 : Form
    {
        public Lab01_Bai3()
        {
            InitializeComponent();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(input.Text);
                if (n >= 0 && n <= 9)
                {
                    switch (n)
                    {
                        case 0:
                            output.Text = "Không";
                            break;
                        case 1:
                            output.Text = "Một";
                            break;
                        case 2:
                            output.Text = "Hai";
                            break;
                        case 3:
                            output.Text = "Ba";
                            break;
                        case 4:
                            output.Text = "Bốn";
                            break;
                        case 5:
                            output.Text = "Năm";
                            break;
                        case 6:
                            output.Text = "Sáu";
                            break;
                        case 7:
                            output.Text = "Bảy";
                            break;
                        case 8:
                            output.Text = "Tám";
                            break;
                        case 9:
                            output.Text = "Chín";
                            break;
                    }
                }
                else MessageBox.Show("Nhập lại các số từ 0 đến 9!");
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lại số nguyên số từ 0 đến 9!");
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
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
