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
            //maskedTextBox1.Mask = "(999)000-0000";
        }
				
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if(e.Position < 5)
            {
                toolTip1.Show("숫자나 공란만 입력 가능", this);
            }
            else
            {
                toolTip1.Show("숫자만 입력 가능", this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = maskedTextBox1.Text + '\n' + maskedTextBox2.Text + '\n' + maskedTextBox3.Text;
            MessageBox.Show(val);
        }
    }
}
