using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лол3
{
    class Program
    {
        public static bool[] NewNode;
        public static int s;
        public static int[] D;
        public static string s2;
        public static Queue<Node> qu;
        public static Arc[] Arcs;
        public static Arc[] Arcs2;
        public static Node[] Nodes;
        public class Node
        {
            public int name;
            public int x;
            public Arc[] dygs;
            public Random ran = new Random();
            public bool Kr;
            public Node(int n)
            {
                name = n;
                x = ran.Next(0, 11);
                //int grC = ran.Next(0, 3);
                //if (grC>0)
                //    gr = new Graph[grC];
            }
            public string Name()
            {
                return "Узел " + name;
            }
        }
        public class Arc
        {
            public Node Finish;  //куда
            public Node Start; //откуда
            public bool Kr;
            public int Len;
            public Arc(Node No, Node St)
            {
                Finish = No;
                Start = St;
                Kr = false;
                Len = 0;

            }
        }
        public static void WriteAll()
        {
            for (int i = 0; i < Nodes.Length; i++)
            {
                Console.Write(Nodes[i].Name() + " -> ");
                for (int j = 0; j < Nodes[i].dygs.Length; j++)
                {
                    Console.Write(Nodes[i].dygs[j].Finish.Name() + "(" + Nodes[i].dygs[j].Len + "),");
                }
                Console.WriteLine();
            }
        }
        public static void WriteAllKrask()
        {
            
            int win = 0;
            for (int i = 0; i < Nodes.Length; i++)
            {
                if (Nodes[i].Kr)
                {
                    Console.Write(Nodes[i].Name() + " -> ");
                    for (int j = 0; j < Nodes[i].dygs.Length; j++)
                    {
                        if (Nodes[i].dygs[j].Kr)
                        {
                            win += Nodes[i].dygs[j].Len;
                            Console.Write(Choose(Nodes[i].dygs[j], Nodes[i]).Name() + "(длина дуги " + Nodes[i].dygs[j].Len + "), ");
                            Nodes[i].dygs[j].Kr = false;
                        }
                    }
                    Console.WriteLine();
                    Nodes[i].Kr = false;
                }
            }
            Console.WriteLine("Длина минимального остовного дерева = " + win);
        }
        public static Node Choose(Arc a, Node n)
        {
            if (n == a.Finish)
                return a.Start;
            else return a.Finish;
        }

        public static void ObhodVGlubiny(Node b)
        {
            //s+=b.Name()+"->";
            NewNode[b.name] = false;
            s++;
            for (int i = 0; i < b.dygs.Length; i++)
            {
                if (NewNode[Choose(b.dygs[i], b).name] && b.dygs[i].Kr)
                {
                    ObhodVGlubiny(Choose(b.dygs[i], b));
                }
            }
        }
        static bool FullKrask()
        {
            for (int i = 0; i < Nodes.Length; i++)
                if (!Nodes[i].Kr)
                    return false;
            int win = 0;
            for (int i = 0; i < Arcs.Length; i++)
                if (Arcs[i].Kr)
                    win++;
            if (win == Nodes.Length - 1)
                return true;
            else return false;
        }
        public static void Krask(Arc a)
        {
            a.Kr = true;
            a.Start.Kr = true;
            a.Finish.Kr = true;
        }
        public static bool TryIt(Arc a)
        {
            a.Kr = true;
            s = 0;
            ObhodVGlubiny(Nodes[0]);
            if (s == Nodes.Length)
                return true;
            else
            {
                a.Kr = false;
                return false;
            }
        }
        public static void Dij(Node k)
        {
            Arcs2 = new Arc[Arcs.Length];
            s = 0;
            for (int i = 0; i < NewNode.Length; i++)
            {
                NewNode[i] = true;
                Nodes[i].Kr = false;
            }
            for (int i = 0; i < Arcs.Length; i++)
                Arcs[i].Kr = false;
            k.Kr = true;
            FindPath(k);
        }
        public static void FindPath(Node n)
        {
            //NewNode[n.name] = false;
            //Arc min;
            if (!FullKrask())
            {
                for (int i = 0; i < n.dygs.Length; i++)
                    if (/*!(n.dygs[i].Start.Kr && n.dygs[i].Finish.Kr) &&*/ !Arcs2.Contains<Arc>(n.dygs[i]))
                    {
                        Arcs2[s] = n.dygs[i];
                        s++;
                    }
                Arc a = FindMin();
                FindPath(ChooseNoKrask(a));
            }
            
        }

        public static Arc FindMin()
        {
            Arc min=null;
            for (int i = 0; i < s; i++)
            {
                if (min == null && Arcs2[i].Kr == false && !(Arcs2[i].Start.Kr && Arcs2[i].Finish.Kr))
                    min = Arcs2[i];
                if (min != null && min.Len > Arcs2[i].Len && Arcs2[i].Kr == false && !(Arcs2[i].Start.Kr && Arcs2[i].Finish.Kr))
                    min = Arcs2[i];
            }
            return min;
        }

        public static Node ChooseNoKrask(Arc a)
        {
            if (a.Start.Kr == false && a.Finish.Kr == true)
            {
                Krask(a);
                return a.Start;
            }
            else if (a.Start.Kr == true && a.Finish.Kr == false)
            {
                Krask(a);
                return a.Finish;
            }
            else return null;
        }



        static void Main(string[] args)
        {
            Arcs = new Arc[0];
            Console.WriteLine("Сколько узлов?");
            int z = Int32.Parse(Console.ReadLine());
            Nodes = new Node[z];
            NewNode = new bool[z];
            D = new int[z];
            qu = new Queue<Node>();
            for (int i = 0; i < z; i++)
            {
                Nodes[i] = new Node(i);
                NewNode[i] = true;
            }
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine("Сколько дуг у узла " + i + "? (до " + (Nodes.Length - 1) + " дуг)");
                int grC = Int32.Parse(Console.ReadLine());
                Nodes[i].dygs = new Arc[grC];
                for (int j = 0; j < grC; j++)
                {
                    bool b = false;
                    while (!b)
                    {
                        Console.WriteLine(i + " указывает на: (" + j + " из " + (grC - 1) + " ссылка)");
                        int t = Int32.Parse(Console.ReadLine());
                        if (t != i && t >= 0 && t < Nodes.Length)
                        {
                            bool New = true;
                            if (Nodes[t].dygs != null)
                                for (int u = 0; u < Nodes[t].dygs.Length; u++)//проверка на существование дуги
                                    if (Nodes[t].dygs[u].Finish == Nodes[i])
                                    {
                                        Nodes[i].dygs[j] = Nodes[t].dygs[u];
                                        Console.WriteLine("<<<АВТОМАТИЧЕСКИ ЗАПОЛЕНО>>>");
                                        New = false;
                                        break;
                                    }
                            if (New)
                            {
                                Nodes[i].dygs[j] = new Arc(Nodes[t], Nodes[i]);
                                Console.WriteLine("длина этой дуги ..?");
                                Nodes[i].dygs[j].Len = Int32.Parse(Console.ReadLine());
                            }
                            b = true;
                        }

                    }
                }
            }
            WriteAll();
            for (int i = 0; i < z; i++)
                for (int j = 0; j < Nodes[i].dygs.Length; j++)
                {
                    if (!Arcs.Contains<Arc>(Nodes[i].dygs[j]))//чтобы не было дублей
                    {
                        Array.Resize<Arc>(ref Arcs, Arcs.Length + 1);
                        Arcs[Arcs.Length - 1] = Nodes[i].dygs[j];
                    }
                }

            for (int i = 0; i < Arcs.Length; i++)//cортировка массива дуг
            {
                for (int j = Arcs.Length - 1; j > i; j--)
                {
                    if (Arcs[j].Len < Arcs[j - 1].Len)
                    {
                        Arc temp = Arcs[j];
                        Arcs[j] = Arcs[j - 1];
                        Arcs[j - 1] = temp;
                    }
                }
            }

            Console.WriteLine();


            for (int i = 0; i < Arcs.Length; i++)
            {
                if (!(Arcs[i].Start.Kr && Arcs[i].Finish.Kr))
                {
                    Krask(Arcs[i]);
                    if (FullKrask())
                        break;
                }
            }
            while (!FullKrask())
            {
                for (int i = 0; i < Arcs.Length; i++)
                    if (!Arcs[i].Kr)
                        if (TryIt(Arcs[i]))
                            break;
                        else
                            for (int j = 0; j < NewNode.Length; j++)
                                NewNode[j] = true;
            }
            Console.WriteLine("АЛГОРИТМ КРАСКАЛА:");
            WriteAllKrask();
            Console.WriteLine();
            Console.WriteLine("АЛГОРИТМ ДЕЙКСТРЫ: откуда ищем путь?");
            int key = Int32.Parse(Console.ReadLine());
            if (key >= 0 && key < Nodes.Length)
            {
                Dij(Nodes[key]);
                WriteAllKrask();
            }
            else
                Console.WriteLine("ОШИБКА ДЕЙКСТРЫ");
            Console.ReadKey();
        }
    }
}
