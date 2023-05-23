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

namespace Lab01
{
    public partial class Lab01_Bai2 : Form
    {
        public Lab01_Bai2()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //double a, b, c;
            double M, m;
            double[] arr = new double[3];
            try
            {
                arr[0] = double.Parse(Num1.Text);
                arr[1] = double.Parse(Num2.Text);
                arr[2] = double.Parse(Num3.Text);
                M = arr[0];
                m = arr[0];
                for (int i = 0; i < 3; i++)
                {
                    if (arr[i] > M)
                        M = arr[i];
                    if (arr[i] < m)
                        m = arr[i];
                }
                MaxResult.Text = M.ToString();
                MinResult.Text = m.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số thực!");
            }           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(Control text in this.Controls)
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
