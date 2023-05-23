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
    public partial class Lab01_Bai4 : Form
    {
        public Lab01_Bai4()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            double value, result;
            try
            {
                value = double.Parse(Values.Text);
                if (Unit.Text == "USD")
                {
                    result = 22772 * value;
                    Results.Text = result.ToString();
                    exchange.Text = "1 USD = 22,772 VND";
                }
                if (Unit.Text == "EUR")
                {
                    result = 28132 * value;
                    Results.Text = result.ToString();
                    exchange.Text = "1 EUR = 28,132 VND";
                }
                if (Unit.Text == "GBP")
                {
                    result = 31538 * value;
                    Results.Text = result.ToString();
                    exchange.Text = "1 GBP = 31,538 VND";
                }
                if (Unit.Text == "SGD")
                {
                    result = 17286 * value;
                    Results.Text = result.ToString();
                    exchange.Text = "1 SGD = 17,286 VND";
                }
                if (Unit.Text == "JPY")
                {
                    result = 214 * value;
                    Results.Text = result.ToString();
                    exchange.Text = "1 JPY = 214 VND";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai, vui lòng nhập lại giá trị!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control text in this.Controls)
            {
                if (text is TextBox)
                    text.Text = "";
                if (text is ComboBox)
                    text.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
