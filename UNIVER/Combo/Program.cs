using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combo
{
    class Program
    {
        static double Fact(double x)
        {
            if (x>1)
            return x * Fact(x - 1);
            else 
                return x;
        }
        static double Razmesh(double n, double m)
        {
            return Fact(n) / Fact(n - m);
        }
        static double Socetan(double n, double m)
        {
            return Razmesh(n,m)/Fact(m);
        }
        static void Main(string[] args)
        {
            string x; 
            bool b=true;
            double n, m;

            Console.WriteLine("Вас приветствует программа для комбинаторики!");
            while (b)
            {
                Console.WriteLine("Введите: 1 - Перестановка");
                Console.WriteLine("         2 - Размещение (берем m из n объектов)");
                Console.WriteLine("         3 - Сочетания (то же, что и 2, но порядок не важен)");
                Console.WriteLine("         0 - выход");
                x = Console.ReadLine();
                switch (x)
                {
                    case ("0"): b = false; break;
                    case ("1"):
                        while (true)
                        {
                            Console.WriteLine("Введите количество элементов (n):");
                            if (Double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.WriteLine("Ответ - "+ Fact(n));
                                break;
                            }
                        }
                        break;
                    case ("2"):
                        while (true)
                        {
                            Console.WriteLine("Введите количество элементов всего (n):");
                            if (Double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.WriteLine("Введите количество выбираемых элементов (m):");
                                if (Double.TryParse(Console.ReadLine(), out m))
                                {
                                    Console.WriteLine("Ответ - "+ Razmesh(n,m));
                                    break;
                                }
                            }
                        }
                        break;

                    case ("3"):
                        while (true)
                        {
                            Console.WriteLine("Введите количество элементов всего (n):");
                            if (Double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.WriteLine("Введите количество выбираемых элементов (m):");
                                if (Double.TryParse(Console.ReadLine(), out m))
                                {
                                    Console.WriteLine("Ответ - "+ Socetan(n, m));
                                    break;
                                }
                            }
                        }
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
