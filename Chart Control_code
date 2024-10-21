using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _240920_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Series 삭제
            chart1.Series.Clear();

            //객체 생성
            Series Chart1 = chart1.Series.Add("Sin Graph");
            Series Chart2 = chart1.Series.Add("Cos Graph");
            Series Chart3 = chart1.Series.Add("Tan Graph");

            //타이틀 객체 생성
            Title title = new Title();

            title.Text = "삼각함수 그래프";
            title.ForeColor = Color.Aqua;
            title.Font = new Font("맑은고딕", 25, FontStyle.Bold);
            chart1.Titles.Add(title);

            //범례 설정
            Chart1.ChartType = SeriesChartType.Line; //선
            Chart2.ChartType = SeriesChartType.Line; //선
            Chart3.ChartType = SeriesChartType.Line; //선

            //차트 색상 설정
            Chart1.Color = Color.Red;
            Chart2.Color = Color.DeepPink;
            Chart3.Color = Color.SeaGreen;

            //차트 굵기 설정
            Chart1.BorderWidth = 5;
            Chart2.BorderWidth = 5;
            Chart3.BorderWidth = 5;

            //범례1 데이터
            for (double i = 0; i < 2 * Math.PI; i += 0.1)
                Chart1.Points.AddXY(i, Math.Sin(i));

            //범례2 데이터
            for (double i = 0; i < 2 * Math.PI; i += 0.1)
                Chart2.Points.AddXY(i, Math.Cos(i));

            //범례3 데이터
            for (double i = 0; i < 0.4 * Math.PI; i += 0.1)
            {
                double tanValue = Math.Tan(i);
                if (Math.Abs(tanValue) < 10) // 큰 값은 제외
                {
                    Chart3.Points.AddXY(i, tanValue);
                }
            }
        }
    }
}
