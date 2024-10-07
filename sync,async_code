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

        private void btn_sync_Click(object sender, EventArgs e)
        {
            //작업이 수행되면 UI thread가 정지됨
            //1초동안 현재 thread를 멈춤
            Thread.Sleep(1000);
            lb_res.Text = "동기식";
        }

        private async void btn_async_Click(object sender, EventArgs e)
        {
            //작업이 수행되어도 UI thread가 정지되지 않음
            //1초 동안 비동기적으로 대기
            await Task.Delay(1000);
            lb_res.Text = "비동기식";
        }

        private void btn_sync_method_Click(object sender, EventArgs e)
        {
            string temp;
            //1입력
            temp = "1";
            //2초 뒤 2 입력
            Thread.Sleep(2000);
            temp += "2";
            //1초뒤 3 입력
            Thread.Sleep(1000);
            temp += "3";

            lb_res.Text = temp;
        }

        private async void btn_async_method_Click(object sender, EventArgs e)
        {
            string temp;
            //1입력
            temp = "1";
            //2초 후에 temp에 2를 추가하는 비동기 작업을 시작
            Task t1 = Task.Run(() =>
            {
                Task.Delay(2000);
                temp += "2";
            });
            //1초 뒤 1입력
            Task t2 = Task.Run(() =>
            {
                Task.Delay(1000);
                temp += "3";
            });
            //t1과 t2 작업이 모두 완료될 때까지 대기
            await Task.WhenAll(t1, t2);

            lb_res.Text = temp;
        }
    }
}
