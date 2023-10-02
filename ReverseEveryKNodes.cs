using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEveryKNodesInLinkedList
{
    public class ReverseEveryKNodes
    {

        Node head;

        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        Node reverse(Node head, int k)
        {
            if (head == null)
                return null;
            Node current = head;
            Node next = null;
            Node prev = null;

            int count = 0;

            while (count < k && current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                count++;
            }

            if (next != null)
                head.next = reverse(next, k);

            return prev;
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
            ReverseEveryKNodes llist = new ReverseEveryKNodes();

            llist.push(9);
            llist.push(8);
            llist.push(7);
            llist.push(6);
            llist.push(5);
            llist.push(4);
            llist.push(3);
            llist.push(2);
            llist.push(1);

            Console.WriteLine("Given Linked List");
            llist.printList();

            llist.head = llist.reverse(llist.head, 3);

            Console.WriteLine("Reversed list");
            llist.printList();
        }
    }

}

