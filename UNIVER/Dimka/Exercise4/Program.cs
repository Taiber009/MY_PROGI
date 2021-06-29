using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)//https://codeforces.com/contest/1286/problem/A
        {
            int n = Int32.Parse(Console.ReadLine()),
                lostSwitch;//этот свич будем постоянно менять
            int[] p = new int[n];
            bool[] b = new bool[n];
            bool nothing = true;
            Stack<int>[] lost = new Stack<int>[2];
            lost[0] = new Stack<int>();
            lost[1] = new Stack<int>();

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                p[i] = Int32.Parse(s[i]);
                if (p[i] != 0)
                    b[p[i] - 1] = true;
            }
            for (int i = 0; i < n; i++)
            {
                if (b[i])
                {
                    nothing = false;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
                if (!b[i])
                    lost[(i + 1) % 2].Push(i + 1);

            if (nothing)//все 0
            {
                int k = 0;
                for (int i = 0; i < lost.Length; i++)
                    while (lost[i].Count > 0)
                        p[k++] = lost[i].Pop();
            }
            else
            {
                int firstNumberIndex = 0,
                    lastNumberIndex = n - 1;
                while (p[firstNumberIndex] == 0)
                    firstNumberIndex++;
                while (p[lastNumberIndex] == 0)
                    lastNumberIndex--;

                int range = 0, //размер дырки
                    maxRange = 0,//макс размер дырки
                    firstNumberIndexSwitch = p[firstNumberIndex] % 2; //чтобы 5 раз заного не расчитывать 


                for (int i = firstNumberIndex + 1; i < lastNumberIndex; i++)//расчет макс размера дыр
                    if (p[i] == 0)
                        range++;
                    else
                    {
                        if (range > maxRange)
                            maxRange = range;
                        range = 0;
                    }
                //Console.WriteLine(); 

                for (int r = 1; r <= maxRange; r++)
                {
                    range = 0;
                    lostSwitch = firstNumberIndexSwitch;
                    for (int i = firstNumberIndex + 1; i <= lastNumberIndex; i++)//дырки (от маленьких до больших)
                        if (p[i] == 0)
                            range++;
                        else
                        {
                            if (p[i] % 2 == lostSwitch)
                            {
                                if (range <= r && range <= lost[lostSwitch].Count)
                                    for (int j = 1; j <= range; j++)
                                        p[i - j] = lost[lostSwitch].Pop();
                            }
                            else
                                lostSwitch = (lostSwitch + 1) % 2;
                            range = 0;
                        }
                }

                //for (int i = 0; i < n; i++)
                //    Console.Write(p[i] + " ");
                //Console.WriteLine();

                lostSwitch = p[lastNumberIndex] % 2;

                if (n - lastNumberIndex - 1 <= lost[lostSwitch].Count)
                    for (int i = lastNumberIndex + 1; i < n; i++)//вперед от lastNumber (только числа =%2)
                        p[i] = lost[lostSwitch].Pop();

                //for (int i = 0; i < n; i++)
                //    Console.Write(p[i] + " ");
                //Console.WriteLine();

                lostSwitch = firstNumberIndexSwitch;

                if (firstNumberIndex <= lost[lostSwitch].Count)//назад от firstNumber (только числа =%2)
                    for (int i = firstNumberIndex - 1; i >= 0; i--)
                        p[i] = lost[lostSwitch].Pop();

                //for (int i = 0; i < n; i++)
                //    Console.Write(p[i] + " ");
                //Console.WriteLine();

                lostSwitch = firstNumberIndexSwitch;

                if (lost[0].Count != 0 || lost[1].Count != 0)//вперед от firstNumber (все числа)
                    for (int i = firstNumberIndex + 1; i < n; i++)
                        if (p[i] != 0)
                            lostSwitch = p[i] % 2;
                        else if (lost[lostSwitch].Count > 0)
                            p[i] = lost[lostSwitch].Pop();
                        else
                        {
                            lostSwitch = (lostSwitch + 1) % 2;
                            p[i] = lost[lostSwitch].Pop();
                        }

                //for (int i = 0; i < n; i++)
                //    Console.Write(p[i] + " ");
                //Console.WriteLine();

                lostSwitch = firstNumberIndexSwitch;

                if (lost[0].Count != 0 || lost[1].Count != 0)//назад от firstNumber (все числа)
                    for (int i = firstNumberIndex - 1; i >= 0; i--)
                        if (p[i] != 0)
                            lostSwitch = p[i] % 2;
                        else if (lost[lostSwitch].Count > 0)
                            p[i] = lost[lostSwitch].Pop();
                        else
                        {
                            lostSwitch = (lostSwitch + 1) % 2;
                            p[i] = lost[lostSwitch].Pop();
                        }
                //for (int i = 0; i < n; i++)
                //    Console.Write(p[i] + " ");
                //Console.WriteLine();
            }
            int win = 0;
            lostSwitch = p[0] % 2;

            for (int i = 1; i < n; i++)//подсчет
                if (p[i] % 2 != lostSwitch)
                {
                    win++;
                    lostSwitch = (lostSwitch + 1) % 2;
                }
            Console.WriteLine(win);
        }

    }
}
