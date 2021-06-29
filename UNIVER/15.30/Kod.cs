using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _15._30
{
    
    class Kod
    {
        public static MyQueue och = new MyQueue();

        public static string read()
        {
            string S = "", a;
            StreamReader file =
                new StreamReader(@"F:\Text.txt");
            while ((a = file.ReadLine()) != null)
                S += a + " ";
            file.Close();

            QueueParse(S);

            return S;
        }

        public static void QueueParse(string S)
        {
            double d;
            string value = "";

            foreach (char x in S)
                if (x != ' ')
                    value += x;
                else
                {
                    d = double.Parse(value);
                    och.InQueue(d);
                    value = "";
                    if (d < 0)
                        och.InQueue(d * -1);
                }
        }

        public static string print()
        {
            string S = "";
            while(!och.QueueIsEmpty())
                S+=och.OutQueue()+" ";
            return S;

        }
    }
}
