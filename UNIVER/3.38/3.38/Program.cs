using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._38
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Введите первую сторону");
            x = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите вторую сторону");
            y = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите третью сторону");
            z = double.Parse(Console.ReadLine());
            Console.Clear();
            if (x < y + z & y < x + z & z < x + y & ((z * z > y * y + x * x) || (y * y > x * x + z * z) || (x * x > y * y + z * z)) & ((x == y) || (y == z) || (z == x)) & x > 0 & y > 0)
            {
                double a, s, p = (x + y + z) / 2;
                s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                Console.WriteLine("Треугольник тупоугольный равнобедренный");
                Console.WriteLine("Стороны равны: " + (Math.Round(x, 2)) + " " + (Math.Round(y, 2)) + " " + (Math.Round(z, 2)));
                Console.WriteLine("Площадь треугольника равна: " + (Math.Round(s, 2)));
                int i = 1;
                while (i < 4)
                {
                    if (y < x) { a = x; x = y; y = a; };
                    if (z < y) { a = y; y = z; z = a; };
                    if (s < z) { a = z; z = s; s = a; };
                    i++;
                };
                Console.WriteLine("В порядке возрастания: "+(Math.Round(x, 2)) + "  " + (Math.Round(y, 2)) + "  " + (Math.Round(z, 2)) + "  " + (Math.Round(s, 2)));
            }
            else { Console.WriteLine("Треугольник не тупоугольный или равнобедренный"); };
            Console.ReadKey();
                
                
                

        }
    }
}
