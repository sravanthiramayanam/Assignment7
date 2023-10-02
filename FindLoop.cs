using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLoopInLinkedList
{
    public class FindLoop
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

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;

            head = new_node;
        }

        Boolean detectLoop()
        {
            Node slow_p = head, fast_p = head;
            while (slow_p != null && fast_p != null
                && fast_p.next != null)
            {
                slow_p = slow_p.next;
                fast_p = fast_p.next.next;
                if (slow_p == fast_p)
                {
                    return true;
                }
            }
            return false;
        }

        //public static void Main(String[] args)
        //{
        //    FindLoop llist = new FindLoop();

        //    llist.push(20);
        //    llist.push(4);
        //    llist.push(15);
        //    llist.push(10);
        //    /*Create loop for testing */
        //    llist.head.next.next.next.next = llist.head;

        //    Boolean found = llist.detectLoop();
        //    if (found)
        //    {
        //        Console.WriteLine("Loop Found");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No Loop");
        //    }
        //}
    }
}

