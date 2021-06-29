using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorevnovanie_test
{



    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Vvedite kolichestvo monetok");
                Console.WriteLine("Vvedite summu");
                Console.WriteLine();

                Random rand = new Random();
                int[] nominal = new int[] { 1, 2, 5, 10 };//Какие есть монетки, можно и руками задать...
                int[] monetki = new int[nominal.Length];//Cколько всего монеток
                int[] monetkiMax = new int[nominal.Length];//Mаксимум монеток, если для набора суммы использовать один тип (чтобы сократить перебор)
                int[] monetkiPerebor = new int[nominal.Length];//Собственно, перебор до monetkiMax

                int win = 0,
                    winKol = 0,
                    nominalMin = -1,
                    kolich = Int32.Parse(Console.ReadLine()),
                    summa = Int32.Parse(Console.ReadLine());
                string[] winString = new string[1000];


                for (int i = 0; i < kolich; i++)
                {
                    monetki[rand.Next(0, 4)]++;
                }
                Console.WriteLine();

                Console.Write("Monetok sgenerirovano: ");
                for (int i = 0; i < nominal.Length; i++)
                {
                    monetkiMax[i] = summa / nominal[i];//По стелсу (пока выводим инфу о сгенерированных монетах) находим макс. количество монет одного типа для суммы (получаем горку)
                    if (monetkiMax[i] > monetki[i])
                        monetkiMax[i] = monetki[i];//Если теоретический максимум больше реального количества монет данного номинала


                    Console.Write(nominal[i] + " RUB - " + monetki[i] + ", ");
                }
                Console.WriteLine();

                for (int i = 0; i < nominal.Length; i++)
                {
                    if (monetkiMax[i] != 0)
                    {
                        nominalMin = i;
                        break;
                    }
                }
                if (nominalMin != -1)
                {
                    Console.WriteLine("Najmite lubyu knopky dlya prodoljeniya:");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Naidennie kombinacii:");

                    while (monetkiPerebor[monetkiPerebor.Length - 1] <= monetkiMax[monetkiMax.Length - 1])//когда переполнится последний элемент в массиве перебора, значит все перебрали
                    {
                        if (win == summa)
                        {
                            winKol++;
                            for (int i = 0; i < monetki.Length; i++)
                            {
                                Console.Write(nominal[i] + " RUB - " + monetkiPerebor[i] + ", ");
                            }
                            Console.WriteLine();
                        }
                        win = 0;
                        monetkiPerebor[nominalMin]++;
                        for (int i = 0; i < monetkiPerebor.Length; i++)
                        {
                            if (monetkiPerebor[i] > monetkiMax[i] && i != monetkiPerebor.Length - 1)//в последнем элементе массива не должно вызываться, а то выход за массив
                            {
                                monetkiPerebor[i] = 0;
                                monetkiPerebor[i + 1]++;//перелив значения в следующий номинал монеток
                            }
                            win += (nominal[i] * monetkiPerebor[i]);
                        }

                    }
                    Console.WriteLine("");
                    Console.WriteLine("Vsego naideno kombinacii: " + winKol);
                }
                else
                    Console.WriteLine("ERROR: Monetok net :'-(");
                Console.WriteLine("");


                /*for (int i = 0; i < monetki.Length; i++)
                {
                    int k = 0;
                    string s = "";
                    win = 0;

                    while (win < summa && k++ < monetki[i])
                    {
                        win = win + nominal[i];
                        s += nominal[i] + " ";
                    }
                    if (win < summa)
                    {
                        for (int mod = 0; mod < nominal.Length - 2; mod++)
                        {
                            lol = 0;
                            for (int j = (i + mod) % monetki.Length; lol++ < 4; j++)
                            {
                                k = 0;
                                while (win < summa && k++ < monetki[j])
                                {
                                    if (win + nominal[j] <= summa)
                                    {
                                        win = win + nominal[j];
                                        s += nominal[j] + " ";
                                    }
                                }
                            }
                        }
                    }
                    if (win >= summa)
                    {
                        Console.WriteLine(s);
                        winString[wS++] = s;
                    }
                }


                for (int i = 1; i < monetki.Length; i++)
                {
                    for (int j = i; j > 0; j--)
                        if (monetki[j] < monetki[j - 1])
                        {
                            lol = monetki[j - 1];
                            monetki[j - 1] = monetki[j];
                            monetki[j] = lol;
                        }
                }*/
            }
        }
    }
}
