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
            //초기 선택 범위 지정
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now.AddDays(3);

            //MaxSelectionCount 디폴트 값은 7일
            monthCalendar1.MaxSelectionCount = 31;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //var tmp = monthCalendar1.SelectionStart.ToShortDateString();
            //범위시작과 끝을 선택하기 위함
            var st = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            var en = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
            textBox1.Text = st;
            textBox2.Text = en;
            //범위 시작 날짜와 범위 끝 날짜가 같으면
            if(monthCalendar1.SelectionStart == monthCalendar1.SelectionEnd)
            {
                textBox3.Text = st;
            }
            else
            {
                textBox3.Text = st + "~" + en;
            }
        }
	//DateTimePicker에서 선택한 날짜 표시
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var ne = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            textBox4.Text = ne;
        }
        
    }
}
