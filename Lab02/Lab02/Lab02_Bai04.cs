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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        FileStream fs;
        public Lab02_Bai04()
        {
            InitializeComponent();
            //MessageBox.Show("Bí rồi ạ, trầm cảm quá ạ, từ bỏ ạ~" +
               // "\nMời bạn chọn bài khác ạ!");

        }
        List<Student> dssv = new List<Student>();
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            open.ShowDialog();
            string content = "";
            fs = new FileStream(open.FileName, FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                content = (string)binaryFormatter.Deserialize(fs);
                
            }catch (SerializationException se) {
                MessageBox.Show(se.Message);
            }
            rtbText.Text = content;
            fs.Close();
        }
        
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "|*.txt";

                string mssv, hoten, sdt;
                float diemToan, diemVan;
                mssv = rtbText.Lines[0];
                hoten = rtbText.Lines[1];
                sdt = rtbText.Lines[2];
                diemToan = (float)Convert.ToDouble(rtbText.Lines[3]);
                diemVan = (float)Convert.ToDouble(rtbText.Lines[4]);

                Student student = new Student();

                if (save.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    fs = File.Create(save.FileName);
                    binaryFormatter.Serialize(fs, student);
                    fs.Close();
                }
            }
            catch (Exception) { }
        }
        [Serializable]
        public class Student
        {
            public string mssv { get; set; } = "";
            public string hoten { get; set; } = "";
            public string sdt { get; set; } = "";
            public float diemToan { get; set; } = 0;
            public float diemVan { get; set; } = 0;
            public float diemTB = -1;
            public void TinhDiemTB()
            {
                diemTB = (diemToan + diemVan) / 2;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbText.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
