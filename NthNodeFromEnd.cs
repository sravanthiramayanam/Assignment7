using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthNodeFromEndOFLinkedList
{
    public class NthNodeFromEnd
    {

        public Node head; 
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }


        void printNthFromLast(int N)
        {
            int len = 0;
            Node temp = head;

            while (temp != null)
            {
                temp = temp.next;
                len++;
            }

            if (len < N)
                return;

            temp = head;
            for (int i = 1; i < len - N + 1; i++)
                temp = temp.next;

            Console.WriteLine(temp.data);
        }

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;

            head = new_node;
        }

        //public static void Main(String[] args)
        //{
        //    NthNodeFromEnd llist = new NthNodeFromEnd();
        //    llist.push(20);
        //    llist.push(4);
        //    llist.push(15);
        //    llist.push(35);


        //    llist.printNthFromLast(2);
        //}
    }


}

