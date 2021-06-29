using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            int[] n = new int[t];
            int[][] p = new int[t][];
            for (int i = 0; i < t; i++)
            {
                n[i] = Int32.Parse(Console.ReadLine());
                p[i] = new int[n[i]];
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < n[i]; j++)
                {
                    p[i][j] = Int32.Parse(input[j]);
                }
            }
            for (int i = 0; i < t; i++)
            {
                int half = n[i]/2;
                if (half > 4 && p[i][0]- p[i][half-1]>1) //минимум 1 2 2
                {
                    int medalGold = p[i][0],
                        medalSilver,
                        medalNoBronze = p[i][half],
                        bronzeBorder = half - 1,
                        gold = 1,
                        silver = 0,
                        bronze,
                        j = 0;

                    while (++j < half && p[i][j] == medalGold)
                    {
                        gold++;
                    }
                    medalSilver = p[i][j];
                    silver++;
                    while (++j < half && (silver <= gold || p[i][j] == medalSilver))
                    {
                        silver++;
                        medalSilver = p[i][j];
                    }
                        while (p[i][bronzeBorder] == medalNoBronze)
                            bronzeBorder--;
                    bronze = bronzeBorder + 1 - gold - silver;

                    if (gold < silver && gold < bronze)
                        Console.WriteLine(gold + " " + silver + " " + bronze);
                    else
                        Console.WriteLine("0 0 0");
                }
                else
                    Console.WriteLine("0 0 0");
            }
        }
    }
}
