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
            //현재 디렉토리 내의 파일리스트 얻기
            //string curDir = Environment.CurrentDirectory;
            string curDir = "C:\\Users\\300514\\Downloads\\Blue Bird Sprite Sheets\\Transparent PNG";
            DirectoryInfo di = new DirectoryInfo(curDir);
            FileInfo[] files = di.GetFiles();

            //리스트뷰 아이템을 업데이트 하기 시작
            //업데이트가 끝날 때 까지 UI 갱신 중지
            listView1.BeginUpdate();

            //뷰모드
            listView1.View = View.Details;

            foreach(var fi in files)
            {
                //각 파일별로 ListViewItem객체를 하나씩 만듦
                //파일명, 사이즈, 날짜 정보를 추가
                ListViewItem lv = new ListViewItem(fi.Name);
                lv.SubItems.Add(fi.Length.ToString());
                lv.SubItems.Add(fi.LastWriteTime.ToString());
                lv.ImageIndex = 0;
                //ListViewItem객체를 Items 속성에 추가
                listView1.Items.Add(lv);
            }
            //컬럼명과 컬럼사이즈 지정
            listView1.Columns.Add("파일명", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("사이즈", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("날짜", 150, HorizontalAlignment.Left);

            //리스트뷰를 Refresh하여 보여줌
            listView1.EndUpdate();
        }

        //start버튼을 누를 시 End버튼이 활성화됨
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        //View 모드 지정
        private void radioDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
        private void radioTitle_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        
    }
}
