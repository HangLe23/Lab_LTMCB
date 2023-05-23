using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 Bai01 = new Lab02_Bai01();
            Bai01.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 Bai02 = new Lab02_Bai02();
            Bai02.Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 Bai03 = new Lab02_Bai03();
            Bai03.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 Bai04 = new Lab02_Bai04();
            Bai04.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 Bai05 = new Lab02_Bai05();
            Bai05.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
