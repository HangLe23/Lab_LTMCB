using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace Lab6
{
    public partial class FTP_Client : Form
    {
        private string host = null;
        private string user = null;
        private string pass = null;
        private FtpWebRequest ftpRequest = null;
        private FtpWebResponse ftpResponse = null;
        private Stream ftpStream = null;
        private int bufferSize = 2048;

        public FTP_Client()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileDownload fileDownload = new FileDownload();
            fileDownload.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                FileDownload.user = txtUser.Text;
                FileDownload.pass = txtPass.Text;
                FTP client = new FTP("ftp://127.0.0.1/", txtUser.Text, txtPass.Text);
                OpenFileDialog uploadFile = new OpenFileDialog();
                string localFile = uploadFile.FileName;
                Console.WriteLine(localFile);
                
                if (uploadFile.ShowDialog() == DialogResult.OK)
                {

                    MessageBox.Show("Da hoan tat ^^");
                }
                else
                    MessageBox.Show("Khong upload duoc");

                string remoteFile = uploadFile.FileName.Substring
                    (uploadFile.FileName.LastIndexOf("\\") + 1);
                client.upload(remoteFile, localFile);
            }
            else
                MessageBox.Show("Vui long nhap ten");
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
