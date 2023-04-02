using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedList
{
    class Node
    {
        public int c;
        public Node next;
        public Node(int c)
        {
            this.c = c;
            next = null;
        }
        
        public void prepand(LinkedList list)
        {
            next = list.first;
            list.first = this;
        }

        public void append(LinkedList list)
        {
            if(list.first ==null)
            {
                list.first = this;
                this.next = null;
            }


            Node node = list.first;
            while(true)
            {
                if (node.next == null) break;
                node = node.next;
            }
            node.next = this;
            this.next = null;
        }
        public void insertAfter(Node node)
        {
            
            Node noodle = node;
            if (noodle.next == null)
            {
                node.next = this;
                noodle.next = null;
            }
            this.next = node.next;
            node.next = this;
            
            

        }

    }

    class LinkedList
    {
        public Node first;

        //
        public void PrintAll()
        {
            Node node = this.first;
            while (true)
            {
                if (node == null) break;
                Console.WriteLine(node.c);
                node = node.next;
            }
        }
    }
}
