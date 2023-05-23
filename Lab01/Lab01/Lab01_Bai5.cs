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
    public partial class Lab01_Bai5 : Form
    {
        public Lab01_Bai5()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            int A, B;
            try
            {
                A = int.Parse(NumA.Text);
                B = int.Parse(NumB.Text);
                Results.Text = "A! = " + giaithua(A) +
                               "\t\tB! = " + giaithua(B) +
                               "\r\nS1 = 1 + 2 + 3 + 4 +...+ A = " + Tong(A) +
                               "\r\nS2 = 1 + 2 + 3 + 4 +...+ B = " + Tong(B) +
                               "\r\nS3 = A^1 + A^2 + A^3 + A^4 +...+ A^B = " + Tong2(A, B);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }
        private int giaithua(int n)
        {
            if (n == 1)
                return 1;
            return n * giaithua(n - 1);
        }
        private int Tong(int n)
        {
            int S = 0;
            for (int i = 1; i <= n; i++)
                S = S + i;
            return S;
        }
        private double Tong2(int a, int b)
        {
            double S = 0;
            for (int i = 1; i <= b; i++)
                S = S + Math.Pow(a, i); 
            return S;
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
