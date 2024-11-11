using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240913_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //폼 로드될 시 주소 검색 창에 문자열 적어놓기
            textBox1.Text = "https://";
        }

        //웹 브라우저를 로딩하는 함수
        public void LoadingWeb()
        {
            string url = textBox1.Text;
            //Navigate메서드에 넣어서 주소를 호출
            webBrowser1.Navigate(url);
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadingWeb();
        }
        //웹 브라우저가 다 로딩되면 완료 메세지 띄우기
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string msg = e.Url + "페이지 로딩 완료";
            MessageBox.Show(msg);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadingWeb();
            }
        }

        
    }
}
