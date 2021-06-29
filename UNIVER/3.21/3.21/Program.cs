using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, a;
            Console.WriteLine("Введите первое число");
            x = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите второе число");
            y = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите третье число");
            z = double.Parse(Console.ReadLine());
            Console.Clear();
            if (y > x) {a=x;x=y;y=a;};
            if (z > y) {a=y;y=z;z=a;};
            if (y > x) {a=x;x=y;y=a;};
            Console.WriteLine("Перечисление чисел в порядке убывания: "+x+" "+y+" "+z);
            Console.Read();
        }
    }
}
