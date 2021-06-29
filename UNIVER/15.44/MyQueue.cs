using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15._44
{
    class Node
    {
        public string S;
        public Node next;
        public Node(string S, Node next)
        {
            this.S = S;
            this.next = next;
        }
    }



    class MyQueue
    {
        Node head;
        Node tail;
        public int count;
        public MyQueue()
        {
            head = null; tail = null; count = 0;
        }
        public bool QueueIsEmpty()
        {
            return head == null;
        }
        public void InQueue(string S)
        {
            Node p = new Node(S, null);
            if (QueueIsEmpty())
            {
                head = p; tail = p;
            }
            else
            {
                tail.next = p; tail = p;
            }
            count++;
        }
        public string OutQueue()
        {
            Node p = head;
            head = head.next;
            count--;
            return p.S;
        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            Node p = head;
            while (p != null)
            {
                Array.Resize<string>(ref st, ++L);
                st[L - 1] = p.S.ToString();
                p = p.next;
            }
            return st;
        }

    }
}
