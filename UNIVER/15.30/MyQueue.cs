using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15._30
{
    class Node 
    {
        public double d;
        public Node next;
        public Node(double d, Node next)   
        {
            this.d = d;
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
        public void InQueue(double d)           
        {
            Node p = new Node(d, null);
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
        public double OutQueue()                   
        {
            Node p = head;
            head = head.next;
            count--;
            return p.d;
        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            Node p = head;
            while (p != null)
            {
                Array.Resize<string>(ref st, ++L);
                st[L - 1] = p.d.ToString();
                p = p.next;
            }
            return st;
        }

    }
}

