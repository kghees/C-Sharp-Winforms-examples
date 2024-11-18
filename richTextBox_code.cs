using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240912_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string filepath = textBox1.Text.ToString();
            //불러올 파일 경로 하드코딩
            string filepath = @"C:\Users\300514\Desktop\새 폴더\test.txt";
            //경로가 존재하는 지 검사
            if (string.IsNullOrEmpty(filepath) || !File.Exists(filepath))
            {
                MessageBox.Show("Invalid file name");
                return;
            }
            //richTextBox1에 파일 불러오기
            richTextBox1.LoadFile(filepath,RichTextBoxStreamType.PlainText);
        }
    }
}
