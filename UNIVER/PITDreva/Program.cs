using System;
using System.Collections.Generic;

namespace Dreva
{
    class Program
    {
        const int padConst = 11;
        static Predicate<Klient>[] pred;
        class Klient
        {
            public int number;
            public int sber;
            public int activ;
            public int dohod;
            public bool risk;

            public Klient(int n, int s, int a, int d, bool r)
            {
                number = n;
                sber = s;
                activ = a;
                dohod = d;
                risk = r;
            }
        }
        class Razbiv
        {
            public List<Klient> listL;
            public List<Klient> listR;
            public double pL;
            public double pR;
            public double p1L;
            public double p2L;
            public double p1R;
            public double p2R;
            public double pLpR;
            public double w;
            public double q;
            //public int end;

            public Razbiv()
            {
                listL = new List<Klient>();
                listR = new List<Klient>();
                //end = 0;
            }
            public string WriteRow()
            {
                return pL.ToString().PadRight(padConst, ' ') + " " +
                        pR.ToString().PadRight(padConst, ' ') + " " +
                        p1L.ToString().PadRight(padConst, ' ') + " " +
                        p2L.ToString().PadRight(padConst, ' ') + " " +
                        p1R.ToString().PadRight(padConst, ' ') + " " +
                        p2R.ToString().PadRight(padConst, ' ') + " " +
                        pLpR.ToString().PadRight(padConst, ' ') + " " +
                        w.ToString().PadRight(padConst, ' ') + " " +
                        q;
            }
            public string ParseListL()
            {
                string s = "";
                for (int i = 0; i < listL.Count; i++)
                    s += " " + listL[i].number;
                return s;
            }
            public string ParseListR()
            {
                string s = "";
                for (int i = 0; i < listR.Count; i++)
                    s += " " + listR[i].number;
                return s;
            }
        }
        static void Main(string[] args)
        {
            List<Klient> klienst = new List<Klient>();
            klienst.Add(new Klient(1, 1, 2, 75, false));
            klienst.Add(new Klient(2, 0, 0, 50, true));
            klienst.Add(new Klient(3, 2, 1, 25, true));
            klienst.Add(new Klient(4, 1, 1, 50, false));
            klienst.Add(new Klient(5, 0, 1, 100, false));
            klienst.Add(new Klient(6, 2, 2, 25, false));
            klienst.Add(new Klient(7, 0, 0, 25, true));
            klienst.Add(new Klient(8, 1, 1, 75, false));

            Razbiv[] raz = new Razbiv[9];
            pred = new Predicate<Klient>[raz.Length];
            pred[0] = (Klient k) => { return k.sber == 0; };
            pred[1] = (Klient k) => { return k.sber == 1; };
            pred[2] = (Klient k) => { return k.sber == 2; };
            pred[3] = (Klient k) => { return k.activ == 0; };
            pred[4] = (Klient k) => { return k.activ == 1; };
            pred[5] = (Klient k) => { return k.activ == 2; };
            pred[6] = (Klient k) => { return k.dohod <= 25; };
            pred[7] = (Klient k) => { return k.dohod <= 50; };
            pred[8] = (Klient k) => { return k.dohod <= 75; };

            Console.WriteLine("Разбиение корня:");
            NewNode(klienst, "Корень");

        }

        static bool IsAllEqual(List<Klient> list)
        {
            if (list.Count < 2)
                return true;
            else
                for (int i = 1; i < list.Count; i++)
                    if (list[0].risk != list[i].risk)
                        return false;
            return true;
        }

        static void NewNode(List<Klient> klienst, string count)
        {
            int win = 0;
            Razbiv[] raz = new Razbiv[9];
            raz[0] = new Razbiv();
            raz[1] = new Razbiv();
            raz[2] = new Razbiv();
            raz[3] = new Razbiv();
            raz[4] = new Razbiv();
            raz[5] = new Razbiv();
            raz[6] = new Razbiv();
            raz[7] = new Razbiv();
            raz[8] = new Razbiv();
            Console.WriteLine("№ PL          PR          P(j|tL)низ  P(j|tL)выс  P(j|tR)низ  P(j|tR)выс  2*PL*PR     W(s|t)      Q(s|t)");
            Console.WriteLine(("").PadRight(104, '-'));
            for (int i = 0; i < raz.Length; i++)
            {
                double p = 0, tL = 0, tR = 0;
                for (int j = 0; j < klienst.Count; j++)
                    if (pred[i](klienst[j]))
                    {
                        raz[i].listL.Add(klienst[j]);
                        p++;
                        {
                            if (!klienst[j].risk)
                                tL++;
                        }
                    }
                    else
                    {
                        raz[i].listR.Add(klienst[j]);
                        {
                            if (!klienst[j].risk)
                                tR++;
                        }
                    }
                raz[i].pL = Math.Round(p / klienst.Count, 5);
                raz[i].pR = Math.Round(1 - raz[i].pL, 5);
                raz[i].p1L = Math.Round(tL / raz[i].listL.Count, 5);
                raz[i].p2L = Math.Round(1 - raz[i].p1L, 5);
                raz[i].p1R = Math.Round(tR / raz[i].listR.Count, 5);
                raz[i].p2R = Math.Round(1 - raz[i].p1R, 5);
                raz[i].pLpR = Math.Round(2 * raz[i].pL * raz[i].pR, 5);
                raz[i].w = Math.Round(Math.Abs(raz[i].p1L - raz[i].p1R) + Math.Abs(raz[i].p2L - raz[i].p2R), 5);
                raz[i].q = Math.Round(raz[i].pLpR * raz[i].w, 5);

                Console.WriteLine(i + 1 + " " + raz[i].WriteRow());
            }

            for (int i = 0; i < raz.Length; i++)
                if (raz[i].listL.Count > 0 && raz[i].listR.Count > 0)//нашли первое разбиение, которое реально разбило
                {
                    win = i;
                    break;
                }
            for (int i = 0; i < raz.Length; i++)
                if (raz[i].q > raz[win].q)//тут только рабочие разбиения
                    win = i;
            //raz[win].end = 11;
            Console.WriteLine();
            Console.WriteLine("Выбор разбиения " + (win + 1));
            Console.WriteLine("Проверка узла " + count + "->Левый");
            if (IsAllEqual(raz[win].listL))
            {
                if (raz[win].listL[0].risk)
                    Console.Write("Все C2:");
                else
                    Console.Write("Все C1:");
                Console.WriteLine(raz[win].ParseListL());
                Console.WriteLine("Это лист.");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Не все равны:");
                Console.WriteLine(raz[win].ParseListL());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Разбиение левого узла уровня " + count + "->Левый");
                NewNode(raz[win].listL, count + "->Левый");//Пряная рекурсия
            }

            Console.WriteLine("Проверка узла " + count + "->Правый");
            if (IsAllEqual(raz[win].listR))
            {
                if (raz[win].listR[0].risk)
                    Console.Write("Все C2:");
                else
                    Console.Write("Все C1:");
                Console.WriteLine(raz[win].ParseListR());
                Console.WriteLine("Это лист.");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Не все равны:");
                Console.WriteLine(raz[win].ParseListR());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Разбиение узла " + count + "->Правый");
                NewNode(raz[win].listR, count + "->Правый");//Пряная рекурсия
            }
        }
    }
}
