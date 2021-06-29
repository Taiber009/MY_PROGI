using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorevnovanie_test
{


    class Program
    {
        static string Task1(int n, int[] p)
        {
            int half = n / 2;
            if (half > 4) //минимум 1 2 2
            {
                int medalGold = p[0],
                    medalBronze = p[half - 1],
                    gold = 1,
                    silver = 0,
                    bronze = 1,
                    bronzeBorder = half - 2;
                if (medalBronze == p[half + 1])
                {
                    while (p[bronzeBorder] == medalBronze)
                        bronzeBorder--;
                    medalBronze = p[bronzeBorder--];
                }

                if (medalGold - medalBronze < 2) 
                    return ("0 0 0");
                for (int i = 1; i < half && p[i] == medalGold; i++)
                    gold++;
                for (int i = bronzeBorder; bronze <= gold || p[i] == medalBronze; i--)
                {
                    bronze++;
                    medalBronze = p[i];
                }
                silver = bronzeBorder + 2 - (gold + bronze);//bronzeBorder + 2 = последний в массиве бронзовый медалист

                if (gold < silver && gold < bronze)
                    return (gold + " " + silver + " " + bronze);
                else
                    return ("0 0 0");
            }
            else
                return ("0 0 0");
        }
        const int MOD = 119 << 23 | 1;

        static int fpow(int a, int k)
        {
            int r = 1, t = a;
            while (k > 0)
            {
                if (k % 2 == 1) r = (int)(long)r * t % MOD;
                t = (int)(long)t * t % MOD;
                k >>= 1;
            }
            return r;
        }
        static string task3String;
        static long Task3(int l, int r, bool left, long c)
        {
            while (l <= r)
            {
                if (left)
                {
                    switch (task3String[l])
                    {
                        case ('('):
                            l++;
                            left = false;
                            break;
                        case (')'):
                            l++;
                            break;
                        case ('?'):
                            return Task3(l + 1, r, false, c) +
                                   Task3(l + 1, r, true, c);
                        default: throw new Exception("ОШИБКА: Введен неправильный символ!");
                    }
                }
                else
                {
                    switch (task3String[r])
                    {
                        case ('('):
                            r--;
                            break;
                        case (')'):
                            r--;
                            left = true;
                            c++;
                            break;
                        case ('?'):
                            return Task3(l, r - 1, false, c) +
                                   Task3(l, r - 1, true, c + 1);
                        default: throw new Exception("ОШИБКА: Введен неправильный символ!");
                    }
                }
            }
            return c;
        }

        static void Main(string[] args)
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Введите номер задачи (1-5):");
                int number;
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    try
                    {
                        switch (number)
                        {
                            case (1):
                                {
                                    Console.WriteLine("A. Beautiful Regional Contest");
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
                                        Console.WriteLine(Task1(n[i], p[i]));
                                    }
                                    break;
                                }
                            case (2):
                                {
                                    Console.WriteLine("B. Красивая последовательность");
                                    string[] input = Console.ReadLine().Split(' ');
                                    int[] n0,
                                          n = new int[4] { Int32.Parse(input[0]),
                                        Int32.Parse(input[1]),
                                        Int32.Parse(input[2]),
                                        Int32.Parse(input[3]) };
                                    int i = 0,
                                        winLenght = n.Sum() * 2 - 1;
                                    string win = "";
                                    bool isWin = true;

                                    if (n[3] > n[0]) //нужно от большего к меньшему
                                    {
                                        Array.Reverse(n);
                                        n0 = new int[4] { 3, 2, 1, 0 };
                                        win += "3";
                                    }
                                    else
                                    {
                                        n0 = new int[4] { 0, 1, 2, 3 };
                                        win += "0";
                                    }
                                    n[0]--; //уже записали в win

                                    while (win.Length < winLenght)
                                    {
                                        if (i > 0 && n[i - 1] > 0)
                                            win += " " + n0[--i];
                                        else if (i < 4 && n[i + 1] > 0)
                                            win += " " + n0[++i];
                                        else
                                        {
                                            Console.WriteLine("NO");
                                            isWin = false;
                                            break;
                                        }
                                        n[i]--;
                                    }
                                    if (isWin)
                                    {
                                        Console.WriteLine("YES");
                                        Console.WriteLine(win);
                                    }
                                    break;
                                }
                            case (3):
                                {
                                    /*Console.WriteLine("D1. Красивая скобочная последовательность (простая версия)");
                                    task3String = Console.ReadLine();
                                    Console.WriteLine(Task3(0, task3String.Length - 1, true, 0) % 998244353);*/
                                    string s = Console.ReadLine();
                                    int n = s.Length;
                                    int[,] dp = new int[n, n];// (n, vector<int>(n));
                                    int[] f = new int[n+1];// vector<int> f(n +1);
                                    for (int i = 0; i < n; i++)
                                    {
                                        if (s[i] != '?')
                                            f[i + 1] = f[i];
                                        else
                                            f[i + 1] += 1;
                                    }
                                    for (int len = 2; len <= n; len++)
                                    {
                                        for (int i = 0; i < n - len + 1; i++)
                                        {
                                            int j = i + len - 1;
                                            if (s[i] != '(')
                                            {
                                                dp[i,j] += dp[i + 1,j];
                                                dp[i,j] %= MOD;
                                            }
                                            if (s[j] != ')')
                                            {
                                                dp[i,j] += dp[i,j - 1];
                                                dp[i,j] %= MOD;
                                            }
                                            if (s[i] != '(' && s[j] != ')')
                                            {
                                                dp[i,j] -= dp[i + 1,j - 1];
                                                dp[i,j] += MOD;
                                                dp[i,j] %= MOD;
                                            }
                                            if (s[i] != ')' && s[j] != '(')
                                            {
                                                dp[i,j] += dp[i + 1,j - 1];
                                                dp[i,j] %= MOD;
                                                dp[i,j] += fpow(2, f[j] - f[i + 1]);
                                                dp[i,j] %= MOD;
                                            }
                                        }
                                    }
                                    Console.WriteLine(dp[0,n - 1]);
                                    break;
                                }
                            case (4):
                                {
                                    Console.WriteLine("E. Красивая лига");
                                    string[] input = Console.ReadLine().Split(' ');
                                    int n = Int32.Parse(input[0]),
                                        m = Int32.Parse(input[1]),
                                        max = n * (n - 1) / 2;
                                    int[] u = new int[m],
                                          v = new int[m];
                                    int[,] mat = new int[n, n];
                                    for (int i = 0; i < m; i++)
                                    {
                                        input = Console.ReadLine().Split(' ');
                                        u[i] = Int32.Parse(input[0]) - 1;
                                        v[i] = Int32.Parse(input[1]) - 1;
                                        mat[u[i], v[i]] = 1;
                                        max -= 1;
                                    }
                                    for (int i = 0; i < m; i++)//ищем тройки на основе заданных матчей
                                    {
                                        for (int j = 0; j < n; j++)
                                        {
                                            if (j != u[i] && j != v[i]) //3!=1 и 3!=2
                                            {
                                                if (mat[j, v[i]] != 1 && mat[u[i], j] != 1)
                                                {//3 не выиграл 2 и 1 не выиграл 3
                                                    int sum = 2 - mat[v[i], j] + mat[j, u[i]];//сколько еще матчей надо доиграть
                                                    if (sum <= max)//не выходим за ограничение по кол-ву матчей
                                                    {
                                                        mat[v[i], j] = mat[j, u[i]] = 1;
                                                        max -= sum;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for (int i = 0; i < n; i++)//по всем остальным до n(n-1)/2
                                    {
                                        for (int j = 0; j < n; j++)
                                        {
                                            if (i != j && max > 0 && mat[j, i] == 0)//2!=1, еще не все матчи сыграны и 2 не выиграл 1
                                                for (int k = 0; k < n; k++)//ищем 3
                                                    if (k != i && k != j && mat[k, j] == 0 && mat[i, k] == 0)
                                                    {//3!=1, 3!=2, 3 не выиграл 2 и 1 не выиграл 3
                                                        int sum = 3 - mat[i, j] + mat[j, k] + mat[k, i];//сколько еще матчей надо доиграть
                                                        if (sum <= max)//не выходим за ограничение по кол-ву матчей
                                                        {
                                                            mat[i, j] = mat[j, k] = mat[k, i] = 1;
                                                            max -= sum;
                                                        }
                                                    }
                                            Console.Write(mat[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    break;
                                }
                            case (5):
                                {
                                    Console.WriteLine("A. Вечная Копилка");//https://codeforces.com/contest/800/problem/A
                                    string[] input = Console.ReadLine().Split(' ');
                                    int n = Int32.Parse(input[0]),
                                        min = 0,
                                        min2 = 0,
                                        win = 0;
                                    double time = 0,
                                           coeff = 0.0001,
                                           p = Double.Parse(input[1]);
                                    double[] a = new double[n],
                                             b = new double[n],
                                             c = new double[n];
                                    for (int i = 0; i < n; i++)
                                    {
                                        input = Console.ReadLine().Split(' ');
                                        a[i] = Double.Parse(input[0]);
                                        b[i] = Double.Parse(input[1]);

                                    }
                                    if (p >= a.Sum())
                                        Console.WriteLine(-1);
                                    else
                                    {
                                        while (win < 2)//конец - когда разрядатся 2 девайса одновременно
                                        {              //(или один, но на зарядке)
                                            win = 0;
                                            for (int i = 0; i < n; i++)
                                                c[i] = b[i] / a[i];//время, через которе гаджет разрядится
                                            for (int i = 0; i < n; i++)
                                                if (c[i] < c[min])
                                                    min = i;//кто разрядится быстрее, его ставим на зарядку
                                            if (a[min] == p)//если скорость заряда и разряда одинаковы,
                                                c[min] = Double.MaxValue;//то гаджет никогда не разрядится(чтобы на 0 не делить)
                                            else
                                                c[min] = b[min] / (a[min] - p);//иначе, вычисляем, когда гаджет разрядится на зарядке (<0 = заряжается)
                                            for (int i = 0; i < n; i++)//кто разрядится быстрее, с учетом, что один девайс на зарядке
                                                if (c[i] < c[min2])
                                                    min2 = i;
                                            if (min == min2)//если девайс на зарядке и он же первый разрядится, то это конец
                                                win++;
                                            time += c[min2];//время, пока разрядится первый девайс 
                                            for (int i = 0; i < n; i++)
                                            {
                                                if (i != min)
                                                    b[i] -= a[i] * c[min2];//разрядка батареи, без зарядки
                                                else
                                                    b[i] -= (a[i] - p) * c[min2];//с зарадкой
                                                if (b[i] < coeff)//если девайс разрядился (близок к 0) - это полпобеды (надо 2 девайса)
                                                    win++;       //взять коэффициент больше?
                                            }
                                        }
                                        Console.WriteLine(time);
                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Введите число (1-5)!");
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ОШИБКА: " + ex.Message);
                    }
                }
                else
                    Console.WriteLine("ОШИБКА: Введите число (1-5)!");
            }
        }
    }
}
