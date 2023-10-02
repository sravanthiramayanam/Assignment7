using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairwiseSwapElementsInLinkedList
{
    public class PairwiseSwapElements
    {
        Node head; 
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

        void pairWiseSwap()
        {
            Node temp = head;

            while (temp != null && temp.next != null)
            {

                int k = temp.data;
                temp.data = temp.next.data;
                temp.next.data = k;
                temp = temp.next.next;
            }
        }

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;

            head = new_node;
        }

        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public static void Main(String[] args)
        {
           PairwiseSwapElements llist = new PairwiseSwapElements();

            llist.push(5);
            llist.push(4);
            llist.push(3);
            llist.push(2);
            llist.push(1);

            Console.WriteLine("Linked List before calling pairWiseSwap() ");
            llist.printList();

            llist.pairWiseSwap();

            Console.WriteLine("Linked List after calling pairWiseSwap() ");
            llist.printList();
        }
    }

}

