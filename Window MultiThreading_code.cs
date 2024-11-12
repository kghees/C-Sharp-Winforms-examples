using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240919_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(th_example);
            th.Start();
        }

        private void th_example()
        {
            Random rd = new Random();

            if (InvokeRequired)
            {
                //BeginInvoke : 비동기 호출
                //Invoke : 동기 호출
                this.tB_random.BeginInvoke(new Action(() =>
               {
                   //Next : 음수가 아닌 임의의 정수 반환
                   this.tB_random.Text = rd.Next().ToString();
               }));
            }
            else
                this.tB_random.Text = "1";
        }
    }
}
