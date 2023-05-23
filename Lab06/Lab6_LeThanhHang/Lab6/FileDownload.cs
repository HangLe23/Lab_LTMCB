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
    public partial class FileDownload : Form
    {

        public static string user;
        public static string pass;
        public FileDownload()
        {
            InitializeComponent();
        }

    

        private void FileDownload_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(user))
                ShowFile($"ftp://127.0.0.1/", user, pass);
        }


        private void ShowFile(string FTPAddress, string user, string pass)
        {
            List<string> files = new List<string>();
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(FTPAddress);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(user, pass);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    Application.DoEvents();
                    files.Add(reader.ReadLine());
                }
                reader.Close();
                responseStream.Close();
                response.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Loi xay ra khi ket noi den FTP Server");
            }

            if (files.Count != 0)
            {
                foreach (string file in files)
                {
                    string[] arrInfo = file.Split('|');
                    ListViewItem info = new ListViewItem(arrInfo);
                    lsvList.Items.Add(info);
                }
            }
        }

        private void lsvDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        FTP ftpClient = new FTP(@"ftp://127.0.0.1/", user, pass);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "";
                saveFile.FileName = "";
                saveFile.Filter = "";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    ftpClient.download(lsvList.SelectedItems[0].Text, saveFile.FileName);
                    MessageBox.Show("Da hoan thanh");
                }
                else
                    MessageBox.Show("Xay ra loi");
            } catch(Exception) {  }
        }
    }
}
