using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionThatReturnsSumListOfTwoLinkedList
{
    class SumListOfTwoLinkedLists
    {
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

        public static Node head1, head2;

        public void addTwoLists(Node l1, Node l2)
        {
            Node prev = null;
            // Create 3 Queues
            Queue<Node> q1 = new Queue<Node>();
            Queue<Node> q2 = new Queue<Node>();
            Queue<Node> q3 = new Queue<Node>();
            // Fill first Queue with first List Elements
            while (l1 != null)
            {
                q1.Enqueue(l1);
                l1 = l1.next;
            }
            // Fill second Queue with second List Elements
            while (l2 != null)
            {
                q2.Enqueue(l2);
                l2 = l2.next;
            }
            int carry = 0;
            // Fill the third Queue with the sum of first and second Queues
            while (q1.Count != 0 && q2.Count != 0)
            {
                int sum
                    = q1.Peek().data + q2.Peek().data + carry;
                Node temp = new Node(sum % 10);
                q3.Enqueue(temp);
                if (sum > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                q1.Dequeue();
                q2.Dequeue();
            }
            while (q1.Count != 0)
            {
                int sum = carry + q1.Peek().data;
                Node temp = new Node(sum % 10);
                q3.Enqueue(temp);
                if (sum > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                q1.Dequeue();
            }
            while (q2.Count != 0)
            {
                int sum = carry + q2.Peek().data;
                Node temp = new Node(sum % 10);
                q3.Enqueue(temp);
                if (sum > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                q2.Dequeue();
            }
            // If carry is still present create a new node with
            // value 1 and Enqueue it to the third stack
            if (carry == 1)
            {
                Node temp = new Node(1);
                q3.Enqueue(temp);
            }
            // Link all the elements inside third stack with
            // each other
            if (q3.Count != 0)
                prev = q3.Peek();
            while (q3.Count != 0)
            {
                Node temp = q3.Peek();
                q3.Dequeue();
                if (q3.Count == 0)
                {
                    temp.next = null;
                }
                else
                {
                    temp.next = q3.Peek();
                }
            }
            printList(prev);
        }

        public void printList(Node head)
        {
            while (head.next != null)
            {
                Console.Write(head.data + " -> ");
                head = head.next;
            }
            Console.WriteLine(head.data);
        }

        public static void Main(String[] args)
        {
            SumListOfTwoLinkedLists list = new SumListOfTwoLinkedLists();

            Node head1 = new Node(5);
            head1.next = new Node(4);
            Console.Write("First List : ");
            list.printList(head1);

            Node head2 = new Node(5);
            head2.next = new Node(4);
            head2.next.next = new Node(3);
            Console.Write("Second List : ");
            list.printList(head2);

            Console.Write("Resultant List : ");

            list.addTwoLists(head1, head2);
        }
    }
}
