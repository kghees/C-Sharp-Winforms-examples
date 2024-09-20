using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240911_1_FTP_
{
    enum Meat
    {
        꽃등심,
        부채살,
        갈비
    }

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            var selected = Meat.꽃등심;
            DisPlayMenu(selected.ToString());
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            var selected = Meat.부채살;
            DisPlayMenu(selected.ToString());
        }
        private void radioButton3_Click(object sender, EventArgs e)
        {
            var selected = Meat.갈비;
            DisPlayMenu(selected.ToString());
        }
        private void DisPlayMenu(string temp)
        {
            label1.Text = $"{temp} 메뉴를 선택하였습니다.";
            label1.BackColor = Color.Yellow;
        }

        
    }
}
