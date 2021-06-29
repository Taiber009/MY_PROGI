using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] n0;
            int[] n = new int[4] { Int32.Parse(input[0]),
                                        Int32.Parse(input[1]),
                                        Int32.Parse(input[2]),
                                        Int32.Parse(input[3]) };
            int winLenght = n.Sum(),
                winIndex = 0,
                def,
                penult = 0,
                last = 1,
                min,
                a = 0, b = 3,
                secondStart = 0;
            char[] win = new char[winLenght];
            bool neighbors = true;

            if (n[3] > n[0]) //нужно от большего к меньшему
            {
                Array.Reverse(n);
                n0 = new char[4] { '3', '2', '1', '0' };
                //if (n[0] > 0 && n[1] > 0)
                //win += "3 2";
            }
            else
            {
                n0 = new char[4] { '0', '1', '2', '3' };
                //if (n[0] > 0 && n[1] > 0)
                //    win += "0 1";
            }
            def = n[1] - n[0];
            if (n[0] <= n[1])
                min = n[0];
            else
                min = n[1];
            while (n[a] == 0 && a <= 4)
                a++;
            while (n[b] == 0 && b >= 0)
                b--;
            if (b - a > 1)
            {
                if (n[a + 1] != 0 && n[b - 1] != 0)
                    neighbors = true;
                else
                    neighbors = false;
            }
            else if (b == a && n[a] == 1)
            {
                Console.WriteLine("YES");
                Console.WriteLine(n0[a]);
                return;
            }
            if (def - n[2] + n[3] == 1)
            {
                win[winIndex++] = n0[1];
                secondStart++;
            }
            if (!neighbors ||
                (n[0] > n[1] && n[2] != 0) ||
                (n[3] > n[2] && n[1] != 0) ||
                n[0] + n[2] + secondStart <= n[1] && n[0] != 0 && n[1] != 0 && n[3] != 0 ||
                n[1] + n[3] <= n[2] && n[0] != 0 && n[2] != 0 && n[3] != 0 ||
                n[2] > def + n[3] + 1 ||
                n[2] < def + n[3] - secondStart)
                Console.WriteLine("NO");
            else
            {
                for (int j = 0; j < min; j++)
                {
                    win[winIndex++] = n0[0];
                    win[winIndex++] = n0[1];
                }
                if (def > 0)
                {
                    for (int j = 0; j < def - secondStart; j++)
                    {
                        win[winIndex++] = n0[2];
                        win[winIndex++] = n0[1];
                    }
                    penult = 2;
                    last = 1;
                }
                if (n[3] > 0)
                {
                    for (int j = 0; j < n[3]; j++)
                    {
                        win[winIndex++] = n0[2];
                        win[winIndex++] = n0[3];
                    }
                    penult = 2;
                    last = 3;
                }
                else if (n[2] == 1)//1 1 1 0
                {
                    penult = 2;
                    last = 3;
                }
                if (last == 3 && n[penult] - def - n[last] == 1 ||
                   (penult == 0 && n[penult] - n[last] == 1) ||
                   (penult == 2 && last == 1 && n[penult] - def == 1))
                    win[winIndex++] = n0[penult];

                Console.WriteLine("YES");
                for (int j = 0; j < winIndex; j++)
                    Console.Write(win[j] + " ");
                
            }
        }
    }
    /*class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] n0,
                  n = new int[4] { Int32.Parse(input[0]),
                                        Int32.Parse(input[1]),
                                        Int32.Parse(input[2]),
                                        Int32.Parse(input[3]) };
            int i = 0,
                winLenght = n.Sum() * 2 - 1,
                def,
                penult = 0,
                last = 1,
                min,
                a = 0, b = 3,
                secondStart = 0;
            string win = "";
            bool neighbors = true;

            if (n[3] > n[0]) //нужно от большего к меньшему
            {
                Array.Reverse(n);
                n0 = new int[4] { 3, 2, 1, 0 };
                if (n[0] > 0 && n[1] > 0)
                    win += "3 2";
            }
            else
            {
                n0 = new int[4] { 0, 1, 2, 3 };
                if (n[0] > 0 && n[1] > 0)
                    win += "0 1";
            }
            def = n[1] - n[0];
            if (n[0] <= n[1])
                min = n[0];
            else
                min = n[1];
            while (n[a] == 0 && a <= 4)
                a++;
            while (n[b] == 0 && b >= 0)
                b--;
            if (b - a > 1)
            {
                if (n[a + 1] != 0 && n[b - 1] != 0)
                    neighbors = true;
                else
                    neighbors = false;
            }
            else if (b == a && n[a] == 1)
            {
                Console.WriteLine("YES");
                Console.WriteLine(n0[a]);
                return;
            }
            if (def - n[2] + n[3] == 1)
            {
                win = n0[1] + " " + win;
                secondStart++;
            }
            if (!neighbors ||
                (n[0] > n[1] && n[2] != 0) ||
                (n[3] > n[2] && n[1] != 0) ||
                n[0] + n[2] + secondStart <= n[1] && n[0] != 0 && n[1] != 0 && n[3] != 0 ||
                n[1] + n[3] <= n[2] && n[0] != 0 && n[2] != 0 && n[3] != 0 ||
                n[2] > def + n[3] + 1 ||
                n[2] < def + n[3] - secondStart)
                Console.WriteLine("NO");
            else
            {
                for (int j = 1; j < min; j++)
                    win += " " + n0[0] + " " + n0[1];
                if (def > 0)
                {
                    for (int j = 0; j < def - secondStart; j++)
                        win += " " + n0[2] + " " + n0[1];
                    penult = 2;
                    last = 1;
                }
                if (n[3] > 0)
                {
                    for (int j = 0; j < n[3]; j++)
                        win += " " + n0[2] + " " + n0[3];
                    penult = 2;
                    last = 3;
                }
                else if (n[2] == 1)//1 1 1 0
                {
                    penult = 2;
                    last = 3;
                }
                if (last == 3 && n[penult] - def - n[last] == 1 ||
                   (penult == 0 && n[penult] - n[last] == 1) ||
                   (penult == 2 && last == 1 && n[penult] - def == 1))
                    win += " " + n0[penult];

                Console.WriteLine("YES" + '\n' + win);
                //Console.WriteLine(win);
            }
        }
    }*/
}
