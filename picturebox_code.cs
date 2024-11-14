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

namespace _240910_1_WinForm예제_
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
        //버튼1 누르면 1번째 사진이 5개 종류대로 표시
        private void button1_Click(object sender, EventArgs e)
        {
            string path = "그림저장되어있는 장소";
            pictureBox1.Load(path); //Normal
            pictureBox2.Load(path); //StretchImage
            pictureBox3.Load(path); //CenterImage
            pictureBox4.Load(path); //Zoom
            pictureBox5.Load(path); //AutoSize
            //pictureBox1.Image = Image.FromFile(path);
        }
        //버튼2 부르면 2번째 사진이 5개 종류대로 표시
        private void button2_Click(object sender, EventArgs e)
        {
            string path = "그림저장되어있는 장소";
            pictureBox1.Image = Image.FromFile(path);
            pictureBox2.Image = Image.FromFile(path);
            pictureBox3.Image = Image.FromFile(path);
            pictureBox4.Image = Image.FromFile(path);
            pictureBox5.Image = Image.FromFile(path);
        }

        
    }
}
