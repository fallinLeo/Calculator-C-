using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        LinkedList list = new LinkedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmake_Click(object sender, EventArgs e)
        {
            

            //첫번째 node
            Node node = new Node(10);
            

            list.first = node;
            //두번째 node
            Node node2 = new Node(20);
            node.next = node2;

            //세번째 node
            Node node3 = new Node(30);
            node2.next = node3;

            //4
            Node node4 = new Node(40);
            node3.next = node4;

            Node node1 = new Node(25);
            node1.insertAfter(node2);
           
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            list.PrintAll();
        }

        private void btnPrepand_Click(object sender, EventArgs e)
        {
            Node node = new Node(5);
            node.prepand(list);
            
        }

        private void btnappend_Click(object sender, EventArgs e)
        {
            Node node = new Node(100);
            node.append(list);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //HOMEWORK
            Node node1 = new Node(25);
            //node1.insertAfter(node2,list); //출력이 10>20>25>30>40 되게 하는 코드 작성

        }
    }
}
