using System;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        struct TimeToDie
        {
            public double time2die;
            public int index;
        }

        static void Main(string[] args)//https://codeforces.com/contest/800/problem/A
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Int32.Parse(input[0]);
            double p = Double.Parse(input[1]),
                   time = 0,
                   aSum,
                   bSum;
            double[] a = new double[n],
                     b = new double[n];
            TimeToDie[] c = new TimeToDie[n];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                a[i] = Double.Parse(input[0]);
                b[i] = Double.Parse(input[1]);
                c[i].index = i;
                c[i].time2die = b[i] / a[i];

            }
            if (p >= a.Sum())
                Console.WriteLine(-1);
            else
            {
                //Sort2(ref c, n);
                Array.Sort(c,(x,y)=> x.time2die.CompareTo(y.time2die));
                aSum = a[c[0].index];
                bSum = b[c[0].index];
                if (aSum > p)
                    time = bSum / (aSum - p);//возможен выход за границу Double?
                else
                    time = Double.MaxValue;
                for (int i = 1; i < n && time > c[i].time2die; i++)
                {
                    aSum += a[c[i].index];
                    bSum += b[c[i].index];
                    if (aSum > p)
                        time = bSum / (aSum - p);
                    else
                        time = Double.MaxValue;
                }
                Console.WriteLine(time);
                
            }
        }
    }
}
