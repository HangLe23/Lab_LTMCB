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
    public partial class Lab02_Bai05 : Form
    {
        public Lab02_Bai05()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            tbPath.Text = folder.SelectedPath;
            DirectoryInfo directory = new DirectoryInfo(tbPath.Text);
            FileInfo[] infos = directory.GetFiles();
            foreach (FileInfo fi in infos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = fi.Length.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = fi.Extension });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = fi.LastWriteTime.ToString() });
                lvShow.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPath.Text = "";
            lvShow.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
