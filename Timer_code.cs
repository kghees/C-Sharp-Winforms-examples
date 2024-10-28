using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Net;
using System.IO;
using Timer = System.Windows.Forms.Timer;

namespace _241028
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //윈폼 타이머 사용
            Timer timer1 = new Timer();
            timer1.Interval = 1000; //1초
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
        }

        //1초마다 Tick 이벤트 핸들러 실행
        void timer_Tick(object sender, EventArgs e)
        {
            //UI thread에서 실행
            //UI 컨트롤 직접 액세스 가능
            label1.Text = DateTime.Now.ToLongTimeString();//시간 문자열 표현
            label2.Text = DateTime.Now.ToLongDateString();//날짜 문자열 표현
        }

    }
}
