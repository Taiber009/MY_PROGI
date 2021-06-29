using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.13.	Вводится последовательность вещественных чисел, оканчивающаяся нулём, и состоящая более чем из одного ненулевого элемента.
            Вывести числа последовательности, добавив к каждому, кроме первого, значение предыдущего.*/
            int i=0, y;
            double[] a = { 1 };
            Console.WriteLine("Введите последовательность из вещественных чисел, оканчивающуюся на 0");
            a[0] = double.Parse(Console.ReadLine());
            if (a[0] != 0)
            {
                for (i = 0; a[i] != 0; i++)
                {
                    Array.Resize<double>(ref a, a.Length + 1);
                    a[i+1] = double.Parse(Console.ReadLine());
                };
            }
            else
            {
                Console.WriteLine("Не менее 1 ненулевого элемента!!!");
            }
            Console.Write("Было:  ");
            y = i;
            for (i = 0; i < y; i++)
            {
                Console.Write(a[i] + " ");
            };
            for (i = y - 1; i > 0; i--)
            {
                a[i] = a[i] + a[i - 1];
            };
            Console.WriteLine();
            Console.Write("Стало: ");
            for (i = 0; i < y; i++)
            {
                Console.Write(a[i] + " ");
            };
            Console.ReadKey();
        }

    }
}
