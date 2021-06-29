using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15._15
{
    class Kod2
    {
        public static Queue<string> go(Queue<string> och1, string S)
        {
            Queue<string> och2 = new Queue<string>();
            while(och1.Count>0)
                if (och1.Peek() != S)
                    och2.Enqueue(och1.Dequeue());
                else
                    och1.Dequeue();
            return och2;
        }
    }
}
