using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//8 вариант

namespace InfBez1
{
    class Program
    {
        const double R0 = 0.666; //от 0 до 1
        const double n = 20; //находим оптимальное n (степень 10 в формуле)
        const int l = 10; //находим оптимальное l (шаг между R и R^)
        const int round = 3; //округление после запятой

        public static double Q(double R, int n)
        {
            return Math.Round(1 / Math.PI * Math.Acos(Math.Cos((10 ^ n) * R)), round);
        }

        static void Main(string[] args)
        {//ФИКСИ БЕСКОНЕЧНОСТЬ!!! upd: пофикшено костылем if ((i - 1) % l != 0)
            int i = 0;
            double R = 0, R1 = 0;
            for (int l2 = 3; l2 <= l; l2++)//находим оптимальное l (шаг между R и R^)
            {
                Console.WriteLine("l = " + l2);
                for (int n2 = 1; n2 <= n; n2++)//находим оптимальное n (степень 10 в формуле)
                {
                    i = 0; R = R0; R1 = R0; //присвоим значение R^=R0 заранее
                    Console.WriteLine("n = " + n2);

                    while (i != l)
                    {
                        i++; R = Q(R, n2);
                        //Console.WriteLine("i = " + i + ", R = " + R);
                    }

                    while (R1 != R)
                    {
                        i++;
                        R = Q(R, n2);
                        if ((i - 1) % l != 0)
                            R1 = Q(R1, n2);
                        //Console.WriteLine("i = " + i + ", R = " + R + ", R^ = " + R1);
                    }

                    Console.WriteLine("Длина = " + i/*+", n = "+n2*/);//Длина L
                    Console.WriteLine();//надо запоминать при каких l и n минимальная длина L???
                }
        }
            Console.ReadKey();
        }
    }
}
