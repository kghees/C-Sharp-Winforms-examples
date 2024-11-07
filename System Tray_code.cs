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
        //Form속성에서 FormClosing 이벤트 설정
        //폼이 닫힐 때 발생되는 이벤트 - 백그라운드 실행
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CloseReason.UserClosing : 사용자가 닫기 버튼을 누를 때
            if(e.CloseReason == CloseReason.UserClosing)
            {
                //폼 닫기 이벤트 취소
                e.Cancel = true;
                //폼 숨기기
                this.Hide();
            }
        }
        //ContextMenuStrip 열기 버튼 속성
        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //폼이 백그라운드로 실행 될 때, 시스템 트레이의 메뉴를 활용해 폼을 보여줌
            this.Show();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //시스템 트레이 메뉴를 활용해 프로그램 종료
            Application.Exit();
        }
    }
}
