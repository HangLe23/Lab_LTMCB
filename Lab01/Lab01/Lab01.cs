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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void btnBT1_Click(object sender, EventArgs e)
        {
            Lab01_Bai1 bt1 = new Lab01_Bai1();
            bt1.Show();
        }

        private void btnBT2_Click(object sender, EventArgs e)
        {
            Lab01_Bai2 bt2 = new Lab01_Bai2();
            bt2.Show();
        }

        private void btnBT3_Click(object sender, EventArgs e)
        {
            Lab01_Bai3 bt3 = new Lab01_Bai3();
            bt3.Show();
        }

        private void btnBT4_Click(object sender, EventArgs e)
        {
            Lab01_Bai4 bt4 = new Lab01_Bai4();
            bt4.Show();
        }

        private void btnBT5_Click(object sender, EventArgs e)
        {
            Lab01_Bai5 bt5 = new Lab01_Bai5();
            bt5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
