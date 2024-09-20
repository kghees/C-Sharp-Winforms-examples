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
            //최대 값 최소 값 설정
            this.numericUpDown1.Maximum = 30;
            this.numericUpDown1.Minimum = -10;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            if(this.numericUpDown1.Value > 30)
            {
                this.numericUpDown1.Value = 30;
            }
            if(this.numericUpDown1.Value < -10)
            {
                this.numericUpDown1.Value = -10;
            }
            
            //썹씨, 화씨 온도 값 설정
            decimal C = numericUpDown1.Value;
            decimal F = C * (9.0M / 5.0M) + 32.0M;

            this.textBox1.Text = F.ToString() + "F";
            
        }
    }
}
