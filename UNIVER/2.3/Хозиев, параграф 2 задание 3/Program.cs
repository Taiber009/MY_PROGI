using System;
namespace Хозиев__параграф_2_задание_3
{class Program
    { static void Main()
      
	{int x,x1,x2,y,y1,y2;
    Console.WriteLine("Введите x1");
    string s = Console.ReadLine();
    x1 = int.Parse(s);
    Console.WriteLine("Введите y1");
    s = Console.ReadLine();
    y1 = int.Parse(s); 
    Console.WriteLine("Введите x2");
    s = Console.ReadLine();
    x2 = int.Parse(s);
    Console.WriteLine("Введите y2");
    s = Console.ReadLine();
    y2 = int.Parse(s);
    Console.WriteLine("Введите x");
    s = Console.ReadLine();
    x = int.Parse(s);
    Console.WriteLine("Введите y");
    s = Console.ReadLine();
    y = int.Parse(s);
    if (x > x1)
        if (x < x2)
            if(y>y1)
                if(y<y2)
          
                 {
                  Console.WriteLine("Точка лежит в прямоугольнике");
                 }
        else
        {
            Console.WriteLine("Точка не лежит в прямоугольнике");
        }
            else
            {
                Console.WriteLine("Точка не лежит в прямоугольнике");
            }
        else
        {
            Console.WriteLine("Точка не лежит в прямоугольнике");
        }
    else
    {
        Console.WriteLine("Точка не лежит в прямоугольнике");
    }
    Console.ReadKey();
	}
}
}

    
