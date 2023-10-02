using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLinkedList
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

    public class MergeTwoSortedLists
    {
   
        Node head;

        public void addToTheLast(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
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

        //public static void Main(String[] args)
        //{
        //    MergeTwoSortedLists llist1 = new MergeTwoSortedLists();
        //    MergeTwoSortedLists llist2 = new MergeTwoSortedLists();

        //    llist1.addToTheLast(new Node(10));
        //    llist1.addToTheLast(new Node(20));
        //    llist1.addToTheLast(new Node(30));

        //    llist2.addToTheLast(new Node(15));
        //    llist2.addToTheLast(new Node(17));
        //    llist2.addToTheLast(new Node(20));

        //    llist1.head = new Assignment7().sortedMerge(llist1.head,
        //                                        llist2.head);
        //    Console.WriteLine("Merged Linked List is:");
        //    llist1.printList();
        //}
    }

    public class Assignment7
    {
        public Node sortedMerge(Node headA, Node headB)
        {

            Node dummyNode = new Node(0);

            Node tail = dummyNode;
            while (true)
            {
                if (headA == null)
                {
                    tail.next = headB;
                    break;
                }
                if (headB == null)
                {
                    tail.next = headA;
                    break;
                }

                if (headA.data <= headB.data)
                {
                    tail.next = headA;
                    headA = headA.next;
                }
                else
                {
                    tail.next = headB;
                    headB = headB.next;
                }

                tail = tail.next;
            }
            return dummyNode.next;
        }
    }

}

