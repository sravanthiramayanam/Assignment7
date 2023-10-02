using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatteningLinkedListUsingPriorityQueue
{
    internal class FlatteningLinkedListPriorityQueue
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node bottom;

            public Node(int x)
            {
                data = x;
                next = null;
                bottom = null;
            }
        }
        public class MyComp : IComparer<Node>
        {
            public int Compare(Node a, Node b)
            {
                return a.data.CompareTo(b.data);
            }

        }
        public class Program
        {
            public static void Flatten(Node root)
            {
                var p = new PriorityQueue<Node>(new MyComp());
                // pushing main link nodes into priority_queue.
                while (root != null)
                {
                    p.Push(root);
                    root = root.next;
                }

                // Extracting the minimum node
                // while priority queue is not empty
                while (!p.Empty())
                {

                    // extracting min
                    var k = p.Top();
                    p.Pop();

                    Console.Write(k.data + " ");
                    if (k.bottom != null)
                        p.Push(k.bottom);
                }
            }

            public class PriorityQueue<T>
            {
                private List<T> queue;
                private IComparer<T> comparer;

                public PriorityQueue(IComparer<T> comparer)
                {
                    queue = new List<T>();
                    this.comparer = comparer;
                }

                public void Push(T element)
                {
                    queue.Add(element);
                    Sort();
                }

                public T Pop()
                {
                    var element = queue[0];
                    queue.RemoveAt(0);
                    return element;
                }

                public T Top()
                {
                    return queue[0];
                }

                public bool Empty()
                {
                    return queue.Count == 0;
                }

                private void Sort()
                {
                    queue.Sort(comparer);
                }
            }

            public static void Main()
            {
                var head = new Node(5);
                var temp = head;
                var bt = head;
                bt.bottom = new Node(7);
                bt.bottom.bottom = new Node(8);
                bt.bottom.bottom.bottom = new Node(30);
                temp.next = new Node(10);

                temp = temp.next;
                bt = temp;
                bt.bottom = new Node(20);
                temp.next = new Node(19);
                temp = temp.next;
                bt = temp;
                bt.bottom = new Node(22);
                bt.bottom.bottom = new Node(50);
                temp.next = new Node(28);
                temp = temp.next;
                bt = temp;
                bt.bottom = new Node(35);
                bt.bottom.bottom = new Node(40);
                bt.bottom.bottom.bottom = new Node(45);

                Flatten(head);
            }
        }
    }
}

    
