using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16._5
{
    public class c
    {
        public double x;
        public double o;
    }
    public class Kod
    {
        public static c[] m = new c[30];

        public static void Go(double X, double a)
        {

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new c();
                m[i].x = X + ((double)i / 10);
                m[i].o = a * Math.Sin((a * m[i].x))
                           * Math.Cos((m[i].x * 2 / a));
            }
            Sort();
            //return Sort(m);
        }
        public static void Sort() //сортировка простыми включениями
        {
            c[] b = new c[30];
            for (int i = 0; i < m.Length; i++)
            {
                b[i] = new c();
                int j = 0;
                while ((j < i) && (b[j].o >= m[i].o))
                    j++;
                for (int k = i; k >= j + 1; k--)
                {
                    b[k].o = b[k - 1].o;
                    b[k].x = b[k - 1].x;
                }
                b[j].o = m[i].o;
                b[j].x = m[i].x;
            }
            m = b;
        }
    }
}
