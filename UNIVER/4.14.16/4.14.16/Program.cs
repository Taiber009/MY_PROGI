using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._14._16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 4.14.XVI
            Console.WriteLine("Введите x:");
            double E, y=0, sum = 0, fack = 1, win = 0, WIN, sign = 1, x = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите N:");
            uint i, proverka, chet = 0, N = uint.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите E:");
            E = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Исходные значения: x={0},N={1},E={2}",x,N,E);
            for (i=0; i < N; i++) {
                y = Math.Pow(x, sign) / fack;
                if (Math.Abs(y) > E) {
                    sum += y;
                    chet += 1;
                };
                win += y;
                sign += 2;
                fack *= sign * (sign - 1);
            };
            proverka = 1;
            Console.WriteLine("Сумма слагаемых sh({0})={1} при N={2}", x, win, N);
            WIN = Math.Sinh(x);
            Console.WriteLine("Истинное значение sh({0})={1}, погрешность={2} ", x, WIN, Math.Abs(WIN - win));
            while (Math.Abs(y) > E) {
                if (proverka == 0) {
                    sum += y;
                    chet += 1;
                }
                else
                {
                    proverka -= 1;
                }

                sign += 2;
                fack *= sign * (sign - 1);
                y = Math.Pow(x, sign) / fack;
            };

            Console.WriteLine("Сумма слогаемых, больших {0} по абсолютному значению, равна {1}, их всего {2}",E,sum,chet);

            Console.ReadKey();
        }
    }
}
