using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240913_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TreeView에 사용할 ImageList에 미리 사진 넣어두기
            treeView1.ImageList = imageList1;

            //첫번째 TreeView 아이템 - 서버
            TreeNode serNode = new TreeNode("서버", 0, 0);
            serNode.Nodes.Add("SE", "서울 서버", 0, 0);
            serNode.Nodes.Add("BS", "부산 서버", 0, 0);
            serNode.Nodes.Add("GJ", "광주 서버", 0, 0);

            //두번째 TreeView 아이템 - 네트워크
            TreeNode netNode = new TreeNode("네트워크", 1, 1);
            netNode.Nodes.Add("LAN", "근거리 통신망", 1, 1);
            netNode.Nodes.Add("MAN", "도시권 통신망", 1, 1);
            netNode.Nodes.Add("WAN", "원거리 통신망", 1, 1);
            
            //2개의 노드를 TreeView에 추가
            treeView1.Nodes.Add(serNode);
            //트리뷰 추가하기
            treeView1.Nodes[0].Nodes.Add("DJ", "대전 서버", 0, 0);
            treeView1.Nodes.Add(netNode);
            //트리뷰 삭제하기(근거리 통신망이 삭제됨)
            //treeView1.Nodes[1].Nodes.RemoveAt(0);


            //모든 트리 노드를 보여주기
            treeView1.ExpandAll();
        }

        //선택된 노드의 Key값을 메시지 박스로 보여줌
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeKey = e.Node.Name;
            if (!string.IsNullOrEmpty(nodeKey))
                MessageBox.Show("선택된 노드 키 : " + nodeKey);
        }
    }
}
