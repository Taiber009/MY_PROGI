using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание__16_Хозиев
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности:");
            string s = Console.ReadLine();
            int r = int.Parse(s);
            double win =(r*2*r*2-r*r*3.14)/4;
            Console.WriteLine("Ответ:");
            Console.WriteLine(win);
            Console.ReadKey();
        }
    }
}
