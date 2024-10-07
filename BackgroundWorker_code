using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240919_1
{
    public partial class Form1 : Form
    {
        private BackgroundWorker bw = new BackgroundWorker();
        private int num = 0;
        private int percent = 0;

        public Form1()
        {
            InitializeComponent();

            //비동기 취소를 지원하는지 여부(스레드 작업 도중 취소 가능 여부)
            bw.WorkerSupportsCancellation = true;
            //진행률 업데이트를 보고할 수 있는지 여부(스레드 작업 진행상황 가능 여부)
            bw.WorkerReportsProgress = true;

            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            //스레드가 run시 호출되는 핸들러 등록
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            //ReportProgressapthem 호출 시 호출되는 핸들러 등록
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressCahnged);
            //스레드 완료(종료)시 호출되는 핸들러 등록
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //결과 텍스트 지우기
            lb_res.Text = string.Empty;

            //숫자 더 이상 변경 못하게 비활성화
            numericUpDown1.Enabled = false;

            //시작버튼 비활성화
            this.btn_start.Enabled = false;

            //취소버튼 활성화
            this.btn_cancel.Enabled = true;

            //숫자 가져오기
            num = (int)numericUpDown1.Value;

            //퍼센트 0으로 초기화
            percent = 0;

            //백그라운드 작업 실행
            bw.RunWorkerAsync(num);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //백그라운드 작업 중지
            bw.CancelAsync();

            //캔슬버튼 비활성화
            btn_cancel.Enabled = false;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //인자값을 받아오기 위해
            BackgroundWorker worker = sender as BackgroundWorker;

            //결과 값에 피보나치 결과 입력
            //DowrokerEventArgs에 결과가 남겨져 있음
            //현재 결과는 bw_RunworkerCompleted에서 확인 가능
            e.Result = Fibonacci((int)e.Argument, worker, e);
        }

        private void bw_ProgressCahnged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //에러 처리
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                //중간에 종료가 된 것이라면
                lb_res.Text = "Canceled";
            else
                //완료가 되었다면
                lb_res.Text = e.Result.ToString();

            //숫자 조정 활성화
            this.numericUpDown1.Enabled = true;

            //시작 버튼 활성화
            btn_start.Enabled = true;

            //종료 버튼 비활성화
            btn_cancel.Enabled = false;
        }

        private long Fibonacci(int n, BackgroundWorker worker, DoWorkEventArgs e)
        {
            //파라미터는 0보다 크고 91보다 작아야함
            //91보다 클 경우 long이 오버플로우가 됨
            if((n < 0) || (n > 91)){
                throw new ArgumentException(
                    "value must be >= 0 and <= 91", "n");
            }

            long res = 0;

            //유저가 취소 했다면 DoworkEventArgs에 Cancel되었다고 입력
            if (worker.CancellationPending)
                e.Cancel = true;
            else
            {
                if (n < 2)
                    res = 1;
                else
                    res = Fibonacci(n - 1, worker, e) + Fibonacci(n - 2, worker, e);
            }

            //중간 처리 값을 지속적으로 보고
            int temp = (int)((float)n / (float)num * 100);

            if(temp > percent)
            {
                percent = num;
                worker.ReportProgress(temp);
            }

            return res;
        }
    }
}
