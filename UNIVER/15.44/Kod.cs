using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _15._44
{
    class Kod
    {
        static MyQueue och = new MyQueue();
        static MyQueue och2 = new MyQueue();

        public static string read()
        {
            string S = "", a;
            StreamReader file =
                new StreamReader(@"F:\Text2.txt", Encoding.GetEncoding("windows-1251"));
            while ((a = file.ReadLine()) != null)
                S += a + " ";
            file.Close();

            QueueParse(S);
            
            return S;
        }

        public static void QueueParse(string S)
        {
            string value = "";
            HashSet<char> Rus = new HashSet<char>();
            for (int i = 1040; i < 1104; i++)
                Rus.Add((char)i);
            Rus.Add((char)203);
            Rus.Add((char)235);

            foreach (char x in S)
                if (!Rus.Contains(x) && value != "")
                {
                    och.InQueue(value);
                    value = "";
                }
                else
                    if (Rus.Contains(x))
                        value += x;
        }

        public static string[] FindMax()
        {
            string[] a = new string[1];
            string S;
            int max = 1, i = 0;

            while (!och.QueueIsEmpty())
            {
                S = och.OutQueue();
                if (S.Length == max)
                {
                    a[i] = S;
                    i++;
                    Array.Resize(ref a, a.Length + 1);
                }
                else
                    if (S.Length > max)
                    {
                        max = S.Length;
                        a = new string[1];
                        a[0] = S;
                        i=1;
                        Array.Resize(ref a, a.Length + 1);
                    }
            }
            return a;
        }

        public static string print()
        {
            string S = "";
            foreach (string x in FindMax())
            {
                    S += x + " ";
            }
            return S;
        }
    }
}
