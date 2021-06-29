using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            Console.WriteLine("Введите сторону A");
            a=double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите сторону B");
            b=double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите сторону C");
            c=double.Parse(Console.ReadLine());
            Console.Clear();
            if (a == b & a == c) { Console.WriteLine("Треугольник равносторонний"); 
                                   double s,vis = Math.Sqrt(a * a - b * b / 4); 
                                   s = vis * a / 2;
                                   if (s <= vis) { Console.WriteLine("Площадь равна " + s); Console.WriteLine("Высота треугольника равна " + vis); }
                                   else { Console.WriteLine("Высота треугольника равна " + vis); };
                                   if (s < a & s > vis) { Console.WriteLine("Площадь равна " + s); };
                                   if (s <= a) { Console.WriteLine("Длина каждой стороны равна " + a); }
                                   else { Console.WriteLine("Длина каждой стороны равна " + a); Console.WriteLine("Площадь равна " + s); };
            } 
            else { Console.WriteLine("Треугольник не равносторонний"); };
            Console.ReadKey();
        }
    }
}
