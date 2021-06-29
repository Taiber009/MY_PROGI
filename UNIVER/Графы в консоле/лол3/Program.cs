using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лол3
{
    class Program
    {




        internal class SubsystemA{

internal string A1(){

return "Subsystem A, Method A1\n";

}

internal string A2(){

return "Subsystem A, Method A2\n";

}

}

internal class SubsystemB{

internal string B1(){

return "Subsystem B, Method B1\n";

}

}

internal class SubsystemC{

internal string C1(){

return "Subsystem C, Method C1\n";

}

}



public static class Facade{

static Library.SubsystemA a = new Library.SubsystemA();

static Library.SubsystemB b = new Library.SubsystemB();

static Library.SubsystemC c = new Library.SubsystemC();

public static void Operation1(){

Console.WriteLine("Operation 1\n" +

a.A1() +

a.A2() +

b.B1());

}

public static void Operation2(){

Console.WriteLine("Operation 2\n" +

b.B1() +

c.C1());

}

}

        /*

                public static bool[] NewNode;
                public static string s;
                public static bool[] NewNode2;
                public static string s2;
                public static Queue<Node> qu;
                public class Node
                {
                    public int count;
                    public int x;
                    public Node[] yzl;
                    public Random ran = new Random();
                    public Node(int s)
                    {
                        count = s;
                        x = ran.Next(0, 11);
                        //int grC = ran.Next(0, 3);
                        //if (grC>0)
                        //    gr = new Graph[grC];
                    }
                    public string Name()
                    {
                        return "Узел " + count;
                    }
                }
                public static void WriteAll(Node[] a)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.Write(a[i].Name() + "-> ");
                        for (int j = 0; j < a[i].yzl.Length; j++)
                        {
                            Console.Write(a[i].yzl[j].Name() + ",");
                        }
                        Console.WriteLine();
                    }
                }
                public static string Start(Node[] a)
                {
                    s = "";
                    Console.Write("В глубину:");
                    for (int i = 0; i < a.Length; i++)
                        if (NewNode[a[i].count])
                            ObhodVGlubiny(a[i]);
                    return s;
                }
                public static void ObhodVGlubiny(Node b)
                {
                    s += b.Name() + "->";
                    NewNode[b.count] = false;
                    for (int i = 0; i < b.yzl.Length; i++)
                    {
                        if (NewNode[b.yzl[i].count])
                        {
                            ObhodVGlubiny(b.yzl[i]);
                        }
                    }
                }



                public static string Start2(Node[] a)
                {
                    s2 = "";
                    Console.Write("В ширину:");
                    for (int i = 0; i < a.Length; i++)
                        if (NewNode2[a[i].count])
                        {
                            ObhodVShiriny(a[i]);
                        }

                    return s2;
                }


                public static void ObhodVShiriny(Node b)
                {
                    s2 += b.Name() + "->";
                    NewNode2[b.count] = false;
                    for (int i = 0; i < b.yzl.Length; i++)
                        qu.Enqueue(b.yzl[i]);
                    for (int i = 0; i < qu.Count; i++)
                    {
                        Node tmp = qu.Dequeue();
                        if (NewNode2[tmp.count])
                            ObhodVShiriny(tmp);
                    }
                }





                static void Main(string[] args)
                {
                    Console.WriteLine("Сколько узлов?");
                    int z = Int32.Parse(Console.ReadLine());
                    Node[] a = new Node[z];
                    NewNode = new bool[z];
                    NewNode2 = new bool[z];
                    qu = new Queue<Node>();
                    for (int i = 0; i < z; i++)
                    {
                        a[i] = new Node(i);
                        NewNode[i] = true;
                        NewNode2[i] = true;
                    }
                    for (int i = 0; i < z; i++)
                    {
                        Console.WriteLine("Сколько дуг у узла " + i + "? (до " + (a.Length - 1) + " дуг)");
                        int grC = Int32.Parse(Console.ReadLine());
                        a[i].yzl = new Node[grC];
                        for (int j = 0; j < grC; j++)
                        {
                            bool b = false;
                            while (!b)
                            {
                                Console.WriteLine(i + " указывает на: (" + j + " из " + (grC - 1) + " ссылка)");
                                int t = Int32.Parse(Console.ReadLine());
                                if (t != i && t >= 0 && t < a.Length)
                                {
                                    a[i].yzl[j] = a[t];
                                    b = true;
                                }
                            }
                        }
                    }
                    WriteAll(a);
                    Console.WriteLine();
                    Console.WriteLine(Start(a));
                    Console.WriteLine(Start2(a));
                    Console.ReadKey();
                }*/
    }
}
