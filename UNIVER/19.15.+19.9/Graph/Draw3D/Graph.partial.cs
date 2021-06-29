using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw3D
{
    public partial class Graph
    {
        // ================= Алгоритмы ==================================
        void ClearVisit()
        {
            int N = Nodes.Length; Lib.Num = 0;
            for (int i = 0; i <= N - 1; i++)
            {
                Nodes[i].visit = false;
                Nodes[i].numVisit = 0;
                Nodes[i].color = Color.White;
                int L = 0;
                if (Nodes[i].Edge != null)
                {
                    L = Nodes[i].Edge.Length;
                    for (int j = 0; j <= L - 1; j++)
                        Nodes[i].Edge[j].color = Color.Silver;
                }
            }
        }

        void VisitTrue(int n)  // отметить посещенный
        {
            Nodes[n].visit = true;
            Lib.Num++;
            Nodes[n].numVisit = Lib.Num;
        }

        void SetDoubleRed(int m, int n)    // закрасить двойственную дугу
        {
            int L = Nodes[m].Edge.Length; bool ok = false; int i = -1;
            while ((i < L - 1) && !ok)
                ok = Nodes[m].Edge[++i].numNode == n;
            if (ok)
                Nodes[m].Edge[i].color = Color.Black;
        }

        void SetEdgeBlack(int v, int i)    // закрасить дугу
        {
            Nodes[v].Edge[i].color = Color.Black;
            SetDoubleRed(Nodes[v].Edge[i].numNode, v);
        }

        public static string StackToStr(MyStack path)
        {
            string result = "";
            while (!path.isEmpty())
            {
                int i = (int)path.Pop();
                result = result + Convert.ToString(i) + " ";
            }
            return result;
        }

        int FindDepth(int n, string nameNode)
        {
            int result = -1;
            VisitTrue(n);                  // отметить посещенный
            if (Nodes[n].name == nameNode)
                result = n;
            else
            {
                int L = 0;
                if (Nodes[n].Edge != null)
                {
                    L = Nodes[n].Edge.Length;
                    int i = -1; result = -1;
                    while ((i < L - 1) & (result == -1))
                    {
                        int m = Nodes[n].Edge[++i].numNode;
                        if (!Nodes[m].visit)
                        {
                            SetEdgeBlack(n, i); // закрасить дугу
                            result = FindDepth(m, nameNode);
                        }
                    }
                }
            }
            return result;
        }

        // Поиск в глубину
        public int DepthSearch(int n, string nameNode)
        {
            ClearVisit();
            int result = FindDepth(n, nameNode);
            return result;
        }

        int FindNotVisit(int t, out int i)
        {
            // t - номер узла, i - номер ребра
            // найти непосещенный узел
            int LL = 0; int result = -1; i = -1;
            if (Nodes[t].Edge != null)
            {
                LL = Nodes[t].Edge.Length;
                bool Ok = false;
                while ((i < LL - 1) && !Ok)
                    Ok = !Nodes[Nodes[t].Edge[++i].numNode].visit;
                if (Ok)
                    result = Nodes[t].Edge[i].numNode;
            }
            return result;
        }

        public int DepthSearchStack(int n, string nameNode)
        {
            Lib.myStack = new MyStack();
            ClearVisit();
            int result = -1;
            VisitTrue(n);                     // отметить посещенный
            do
            {
                if (Nodes[n].name == nameNode)
                    result = n;               // узел найден
                else
                {
                    int i;
                    int m = FindNotVisit(n, out i); // найти непосещенный узел
                    if (m != -1)
                    {
                        SetEdgeBlack(n, i);   // закрасить дугу
                        Lib.myStack.Push(n);  // поместить в стек
                        VisitTrue(m);         // отметить посещенный
                        n = m;
                    }
                    else
                        n = (int)Lib.myStack.Pop(); // взять из стека
                }
            }
            while (!(Lib.myStack.isEmpty() || (result != -1)));
            return result;
        }

        public int BreadthSearch(int v, string nameNode)
        // поиск в ширину
        {
            ClearVisit();
            Lib.myStack = new MyStack();
            int result = -1;
            VisitTrue(v);                    // отметить посещенный
            Lib.myStack.PushQueue(v);        // поместить в очередь
            while (!Lib.myStack.isEmpty() && (result == -1))
            {
                v = (int)Lib.myStack.Pop();  // взять из очереди
                if (Nodes[v].Edge != null)
                {
                    int L = Nodes[v].Edge.Length;
                    int i = -1;
                    while ((i < L - 1) && (result == -1))
                    {
                        int m = Nodes[v].Edge[++i].numNode;
                        if (!Nodes[m].visit)     // еще не посещали
                        {
                            SetEdgeBlack(v, i);  // закрасить дугу
                            Lib.myStack.PushQueue(m); // поместить в очередь
                            if (Nodes[m].name == nameNode)
                                result = m;
                            VisitTrue(m);        // отметить посещенный
                        }
                    }
                }
            }
            return result;
        }

        void FindDepth(int n)
        {
            VisitTrue(n);              // отметить посещенный
            int LL = 0;
            if (Nodes[n].Edge != null)
            {
                LL = Nodes[n].Edge.Length; int i = -1;
                while (i < LL - 1)
                {
                    int m = Nodes[n].Edge[++i].numNode;
                    if (!Nodes[m].visit)
                    {
                        SetEdgeBlack(n, i); // закрасить ребро
                        FindDepth(m);
                    }
                }
            }
        }

        public void SetTreeDepth(int n)
        // построение стягивающего дерева (остов) - поиск в глубину
        {
            ClearVisit();
            FindDepth(n);
        }

        int FindEdge(int v)
        {
            int LL = 0;
            if (Nodes[v].Edge != null)
            {
                LL = Nodes[v].Edge.Length;
                bool Ok = false; int i = -1;
                while ((i < LL - 1) & !Ok)
                    Ok = Nodes[v].Edge[++i].color != Color.Black;
                if (Ok)
                    return i;
                else
                    return -1;
            }
            else
                return -1;
        }

        public void PathEuler()
        {
            ClearVisit();
            Lib.myStack = new MyStack();
            Lib.path = new MyStack();
            int v = 0;
            Lib.myStack.Push(v);             // положить в стек
            while (!Lib.myStack.isEmpty())
            {
                int i = FindEdge(v);
                if (i != -1)
                {
                    int u = Nodes[v].Edge[i].numNode;
                    Lib.myStack.Push(u);    // положить в стек
                    SetEdgeBlack(v, i);     // закрасить ребра
                    v = u;
                    //Lib.path.Push(v);
                }
                else
                {
                    v = (int)Lib.myStack.Pop();// взять из стека
                    Lib.path.Push(v);          // положить в стек
                }
                //Lib.path.Push(v);
            }
        }

        string SetPath(int sum)
        {
            string result = "";
            for (int j = 1; j < Nodes.Length + 1; j++)
                result += Convert.ToString(Lib.arr[j]);
            result += Convert.ToString(Lib.arr[1]);
            //
            return result + " " + sum;
        }


        void Gamilt(int k, ref System.Windows.Forms.ListBox.ObjectCollection Items)
        {
            int y = Lib.arr[k - 1];
            int LL = 0;
            if (Nodes[y].Edge != null)
            {
                LL = Nodes[y].Edge.Length;
                for (int i = 0; i < LL; i++)
                {
                    int u = Nodes[y].Edge[i].numNode;
                    if (k == Nodes.Length + 1)
                    {
                        Lib.arr[k] = u;
                        Items.Add(SetPath(0)); // вывести путь
                    }
                    else
                        if (!Nodes[u].visit)
                        {
                            Lib.arr[k] = u;
                            Nodes[u].visit = true; // отметить посещенный
                            Gamilt(k + 1, ref Items);
                            Nodes[u].visit = false;// отметить посещенный
                        }
                }
            }
        }

        bool Test(int y, ref int m)
        {
            bool res = false;
            if (Nodes[y].Edge != null)
            {
                int i = -1;
                while ((i < Nodes[y].Edge.Length - 1) && !res)
                {
                    res = Nodes[y].Edge[++i].numNode == begNode;
                }
                if (res)
                    m = i;
            }
            return res;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static MyStack puti = new MyStack();
        public static Koords xy;
        public static string S = "";
        public struct Koords
        {
            public double[] x;
            public double[] y;
            public int i;
        }
        public static string reformat(string s)
        {
            string s2 = "";
            bool perim = false;
            for (int i = 1; i < s.Length; i++)
            {
                if (perim)
                    s2 += s[i];
                if (s[i] == ' ')
                    perim = true;
            }
            return s2;
        }
        public static string Go()
        {
            string s = "", s1, win = "false ";
            int x = 0, y;
            while (!puti.isEmpty())
            {
                s1 = (string)puti.Pop();
                if (FindWin(s1))
                {
                    s += s1 + "   ";
                    y = Int32.Parse(reformat(s1));
                    if (y > x)
                    {
                        x = y;
                        win = s1;
                    }
                }
            }
            s += Environment.NewLine + "Ответ: " + win;
            s1 = "";
            for (int i = 0; win[i] != ' '; i++)
            {
                s1 += win[i];
                if (win[i] == ' ')
                    break;
            }
            Lib.graph.New(s1);
            return s;
        }
        public static bool FindWin(string s)
        {
            xy.x = new double[5000];
            xy.y = new double[5000];
            xy.i = 0;
            for (int i = 1; i < s.Length; i++)
            {
                string n1 = "", n2 = "";
                n1 += s[i - 1];
                n2 += s[i];
                if (n2 == " ")
                    break;
                if (!ProverkaPutei(Int32.Parse(n1), Int32.Parse(n2)))
                {
                    return false;
                }

            }
            return true;
        }
        public static bool ProverkaPutei(int i1, int i2)
        {
            double raznX = (Nodes[i2].x - Nodes[i1].x);
            double raznY = (Nodes[i2].y - Nodes[i1].y);
            double raznXM = raznX; if (raznXM < 0) raznXM *= -1;
            double raznYM = raznY; if (raznYM < 0) raznYM *= -1;
            double mnojX = 1;
            double mnojY = 1;
            double dlina = 0;
            double X = Nodes[i1].x, Y = Nodes[i1].y;

            if (raznYM - raznXM > 0)
            {
                dlina = raznYM;                         //идем по Y коорд по +-1
                if (raznX != 0) mnojX = raznX / raznYM; //идем по X коорд по +-меньше 1(дробное значение)
                else mnojX = 0;                         //если узлы на одной X коорд, то не идем по Х
                if (raznY < 0) mnojY = -1;              //если идем по Y коорд по -1
            }
            else
            {
                dlina = raznXM;                         //идем по X коорд по +-1
                if (raznY != 0) mnojY = raznY / raznXM;
                else mnojY = 0;
                if (raznX < 0) mnojX = -1;
            }


            for (int j = 0; j < dlina; j++)
            {
                X += mnojX;
                Y += mnojY;
                for (int j2 = 0; j2 <= xy.i; j2++)
                {
                    if (
                        ((int)X - xy.x[j2] < 2) && ((int)X - xy.x[j2] > -2)
                     && ((int)Y - xy.y[j2] < 2) && ((int)Y - xy.y[j2] > -2)
                     && (xy.i - j2 > 10) && (j2 > 10)
                        )
                        return false;
                }
                xy.x[xy.i] = (int)X; xy.y[xy.i] = (int)Y;//заносим коорд-ы в структуру
                xy.i++;

            }
            return true;
        }

        public static bool FindWin2(string s)
        {
            xy.x = new double[5000];
            xy.y = new double[5000];
            xy.i = 0;
            for (int i = 2; i < s.Length; i++)
            {
                string n1 = "", n2 = "";
                n1 += s[i - 1];
                n2 += s[i];
                if (n2 == " ")
                    break;
                for (int j = 1; j < i; j++)
                {
                    string n3 = "", n4 = "";
                    n3 += s[j - 1];
                    n4 += s[j];
                    if (!ProverkaPutei2(Int32.Parse(n1), Int32.Parse(n2), Int32.Parse(n3), Int32.Parse(n4)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool ProverkaPutei2(int i1, int i2, int i3, int i4)
        {
            double x1 = Nodes[i1].x, y1 = Nodes[i1].y,
                   x2 = Nodes[i2].x, y2 = Nodes[i2].y,
                   x3 = Nodes[i3].x, y3 = Nodes[i3].y,
                   x4 = Nodes[i4].x, y4 = Nodes[i4].y;
            double k = ((y2 - y1) / (x2 - x1) - (y1 - y3)) * (x4 - x3) / (y4 - y3);
            double x = (x1 * k - x3) / (k - 1);
            double y = (x - x1) * (y2 - y1) / (x2 - x1) + y1;
            double y0 = (x - x3) * (y4 - y3) / (x4 - x3) + y3;
            if ((y - y0 < 2) && (y - y0 > -2) && (i1 != i4) && ((i2 != 0) || (i3 != 0)))
                return false;
            else
                return true;
        }

        public static void Go2(int i, string put, int dlina)
        {
            if (put.Length > Nodes.Length * 5)  //беск цикл
            { S += "Ошибка " + put + Environment.NewLine; }
            else
            {
                //if (Nodes[i].numVisit == 0)   //если новый элемент
                // Nodes[i].numVisit = put.Length;
                //if ((i == 0) && (put.Length > 1)) //если вернулись домой
                // domoi.Clear();
                int x = 0;
                for (int j = 0; j < put.Length; j++) //сколько узлов прошли
                {
                    x++;
                    for (int k = 0; k < j; k++)
                        if (put[j] == put[k])
                        {
                            x--;
                            break;
                        }
                }
                if ((i == 0) && (x >= Nodes.Length))//если вернулись домой и все прошли
                {
                    if(dlina < 101)
                    S += put + " " + dlina + " км" + Environment.NewLine;
                }
                else
                {
                    bool typik = true;
                    if (x < Nodes.Length) //все ли узлы прошли
                    { //если нет
                        for (int j = 0; j < Nodes[i].Edge.Length; j++) //по ребрам узла идем
                        {
                            bool New = true;
                            for (int j2 = 0; j2 < put.Length; j2++)
                                if (Nodes[i].Edge[j].numNode == Int32.Parse("" + put[j2])) //были ли тут
                                    New = false;
                            if (New) //если не были
                            {
                                typik = false;
                                Go2(Nodes[i].Edge[j].numNode, put + Nodes[i].Edge[j].numNode, dlina + Nodes[i].Edge[j].A);

                            }
                        }
                        if (typik) //если новых рядом нет, надо выйти из тупика
                        {
                            int j2 = 0;
                            for (int i2 = 0; i2 < put.Length; i2++)
                                if (Int32.Parse("" + put[i2]) == i)
                                {
                                    j2 = Int32.Parse("" + put[i2 - 1]); //узел, который был до нынешнего
                                    break;
                                }
                            for (int j3 = 0; j3 < Nodes[i].Edge.Length; j3++)
                                if (Nodes[i].Edge[j3].numNode == j2) //ищем ребро к этом узлу
                                {
                                    Go2(j2, put + j2, dlina + Nodes[i].Edge[j3].A); 
                                    break;
                                }
                            //  if (!nezero)//кроме 0 нет ближающих
                            //   for (int j3 = 0; j3 < Nodes[i].Edge.Length; j3++)
                            //   if (Nodes[i].Edge[j3].numNode == 0)
                            //  {
                            //      Go2(0, put + 0, dlina + Nodes[i].Edge[j3].A);
                            //      break;
                            //   }             
                            /*
                            int min2 = 0, min = 0;
                            for (int k = 0; k < Nodes[i].Edge.Length; k++)
                            {
                                if (k == 0)
                                    min = Nodes[i].Edge[k].numNode;
                                if (Nodes[i].Edge[k].numNode < min)
                                {
                                    min = Nodes[i].Edge[k].numNode;
                                    min2 = k;
                                }
                            }
                            if (domoi.Count() > 0)
                                domoi.Pop();
                            Go2(min, put + min, dlina + Nodes[i].Edge[min2].A, domoi);*/
                        }

                    }
                    else //если все прошли, надо вернуть в узел 0
                    {
                        bool zero = false;
                        for (int n = 0; n < Nodes[i].Edge.Length; n++)//вдруг рядом есть путь к 0
                            if (Nodes[i].Edge[n].numNode == 0)
                            {
                                zero = true;
                                Go2(0, put + 0, dlina + Nodes[i].Edge[n].A);
                            }
                        if (!zero)//если нет, то используем алгоритм и ищем минимальный путь назад
                            Go2(0, put + "->" + 0, dlina + Nodes[i].dist);
                            /*
                            {
                            if (domoi.Count() > 0)
                            {
                                int j = (int)domoi.Pop();
                                for (int k = 0; k < Nodes[i].Edge.Length; k++)
                                    if (j == Nodes[i].Edge[k].numNode)
                                        Go2(j, put + j, dlina + Nodes[i].Edge[k].A, domoi);
                            }
                            else
                                S += "Ошибка стака "+put+Environment.NewLine;*/ 
                    }
                }

            }
        }
        

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        void GamiltC(int k, ref System.Windows.Forms.ListBox.ObjectCollection Items)
        {
            int sum = 0;
            int count = 0;
            int y = Lib.arr[k - 1];
            int LL = 0;
            if (Nodes[y].Edge != null)
            {
                LL = Nodes[y].Edge.Length;
                for (int i = 0; i < LL; i++)
                {
                    sum = Nodes[y].Edge[i].A;

                    int u = Nodes[y].Edge[i].numNode;
                    if (k == Nodes.Length + 1)
                    {
                        Lib.arr[k] = u;
                        int m = 0;
                        if (Test(y, ref m))
                        {
                            sumDist += Nodes[y].Edge[m].A;
                            Items.Add(SetPath(sumDist)); // вывести путь
                            puti.Push(SetPath(sumDist));////////////////////// В СТЕК ВСЕ ВОЗМОЖНЫЕ ПУТИ
                            count++;
                            Program.formListBox.progressBar1.Value = count;
                            Program.formListBox.progressBar1.Refresh();

                            PathGam p = new PathGam();
                            p.sum = sumDist;
                            for (int j = 1; j < k; j++)
                                p.path.Add(Lib.arr[j]);
                            Lib.pathsGam.Add(p);

                            sumDist -= Nodes[y].Edge[m].A;
                            return;
                        }
                    }
                    else
                        if (!Nodes[u].visit)
                        {
                            Lib.arr[k] = u;
                            sumDist += sum;
                            Nodes[u].visit = true; // отметить посещенный
                            GamiltC(k + 1, ref Items);
                            sumDist -= sum;
                            Nodes[u].visit = false;// отменить посещенный
                        }
                }
            }
        }

        int begNode = 0;
        int sumDist = 0;

        public void Gamilton(System.Windows.Forms.ListBox.ObjectCollection Items)
        {
            ClearVisit();
            int N = Nodes.Length;
            int v0 = 0;
            Lib.arr[1] = v0;
            begNode = v0;
            sumDist = 0;
            VisitTrue(v0);                    // отметить посещенный
            Lib.pathsGam.Clear();
            GamiltC(2, ref Items);
        }

        void SetMatr()
        {
            int N = Nodes.Length;
            A = new int[N, N];
            for (int i = 0; i <= N - 1; i++)
                for (int j = 0; j <= N - 1; j++)
                    A[i, j] = 0xFFFFF; // int.MaxValue; 
            for (int i = 0; i <= N - 1; i++)
            {
                A[i, i] = 0;
                int LL = 0;
                if (Nodes[i].Edge != null)
                {
                    LL = Nodes[i].Edge.Length;
                    for (int j = 0; j <= LL - 1; j++)
                        A[i, Nodes[i].Edge[j].numNode] = Nodes[i].Edge[j].A;
                }
            }
        }

        public void MinDist0(int s)
        {
            SetMatr();
            int N = Nodes.Length;
            for (int v = 0; v <= N - 1; v++)
                Nodes[v].dist = A[s, v];
            Nodes[s].dist = 0;
            for (int k = 0; k <= N - 1; k++)
                for (int v = 0; v <= N - 1; v++)
                    if (v != s)
                        for (int u = 0; u <= N - 1; u++)
                            Nodes[v].dist =
                                Math.Min(Nodes[v].dist, Nodes[u].dist + A[u, v]);
        }

        public int Count = 0;

        public void Bellmann(int from)
        // было ли на этом шаге изменено значение кратчайшего
        // пути хоть до одной вершины
        {
            int N = Nodes.Length;
            bool Ok;
            for (int i = 0; i <= N - 1; i++)
                if (i == from)
                    Nodes[i].dist = 0;
                else
                    Nodes[i].dist = 0xFFFFF;
            do
            {
                // сохраняем значение кратчайшего пути на предыдущем шаге
                for (int i = 0; i <= N - 1; i++)
                    Nodes[i].oldDist = Nodes[i].dist;
                Ok = false;
                for (int i = 0; i <= N - 1; i++)
                {
                    int LL = 0;
                    if (Nodes[i].Edge != null)
                    {
                        LL = Nodes[i].Edge.Length;
                        if (LL > 0)
                            // просматриваем ребра, входящие в текущую вершину
                            for (int j = 0; j <= LL - 1; j++)
                            {
                                Count++;
                                if (Nodes[i].Edge[j].A + Nodes[Nodes[i].Edge[j].numNode].oldDist <
                                    Nodes[i].dist) // если нашли путь короче
                                {
                                    Nodes[i].dist =
                                        Nodes[i].Edge[j].A + Nodes[Nodes[i].Edge[j].numNode].oldDist; // исправляем Dist
                                    Ok = true;                          // и ставим флаг
                                }
                            }
                    }
                }
            }
            while (Ok); // если очередная итерация прошла неуспешно
        }

        int FindMinDist(int p)
        {
            int MinDist = 0xFFFFF; // int.MaxValue;
            int result = 0;
            int N = Nodes.Length;
            for (int i = 0; i <= N - 1; i++)
            {
                Count++;
                if (!Nodes[i].visit && (i != p))
                {
                    Nodes[i].dist = Math.Min(Nodes[i].dist, Nodes[p].dist + A[p, i]);
                    if (Nodes[i].dist < MinDist)
                    {
                        MinDist = Nodes[i].dist;
                        result = i;
                    }
                }
            }
            return result;
        }

        void PathToStack(int s, int p)
        {
            Lib.myStack = new MyStack();
            int N = Nodes.Length;
            while (p != s)
            {
                Lib.myStack.Push(p); // положить в стек
                int i = -1; bool Ok = false;
                while ((i < N - 1) & !Ok)
                {
                    Count++;
                    Ok = (++i != p) && (Nodes[p].dist == Nodes[i].dist + A[i, p]);
                }
                p = i;
            }
        }

        public int Dijkst(int s, int t)
        {
            Count = 0;
            int result;
            ClearVisit();
            SetMatr();
            // Инициализация
            int N = Nodes.Length;
            for (int i = 0; i <= N - 1; i++)
                Nodes[i].dist = 0xFFFFF; // int.MaxValue;
            Nodes[s].dist = 0; VisitTrue(s);
            int p = s;
            do
            {
                p = FindMinDist(p); // обновление и найти
                VisitTrue(p);       // пометка = false
            }
            while (p != t);
            result = Nodes[p].dist;
            PathToStack(s, p);

            return result;
        }

        void SortNumEdge(ref int[] V)
        {
            int N = Nodes.Length;
            int L1, L2;
            for (int i = 0; i <= N - 1; i++) V[i] = i;
            for (int i = 0; i <= N - 2; i++)
                for (int j = N - 1; j >= i + 1; j--)
                {
                    if (Nodes[V[j]].Edge != null)
                        L1 = Nodes[V[j]].Edge.Length;
                    else
                        L1 = 0;
                    if (Nodes[V[j - 1]].Edge != null)
                        L2 = Nodes[V[j - 1]].Edge.Length;
                    else
                        L2 = 0;

                    if (L1 < L2)
                    {
                        int t = V[j]; V[j] = V[j - 1]; V[j - 1] = t;
                    }
                }
        }

        bool IsBorder(int i, int k)
        {
            int j = -1; bool result = false;
            int N = Nodes.Length;
            while ((j < N - 1) & !result)
                result = Nodes[++j].visit & (Nodes[j].color == Colors[k]) & (A[i, j] != 0xFFFFF);
            return result;
        }

        public int SetColor()
        // переборный алгоритм закраски
        {
            int N = Nodes.Length;
            int[] V = new int[N];
            for (int i = 0; i <= N - 1; i++)
                V[i] = i;
            SortNumEdge(ref V);
            ClearVisit(); SetMatr();
            bool Ok;
            int k = 0;
            do
            {
                Ok = false; int i = -1;
                while ((i < N - 1) & !Ok)
                    Ok = !Nodes[V[++i]].visit;
                if (Ok)                           // найдена неокрашенная
                {
                    VisitTrue(V[i]);              // окрасили
                    Nodes[V[i]].color = Colors[k];

                    for (i = 0; i <= N - 1; i++)
                        if (!Nodes[V[i]].visit &  // не окрашена
                            !IsBorder(V[i], k))   // нет соседей цвета k
                        {
                            VisitTrue(V[i]);      // окрашено
                            Nodes[V[i]].color = Colors[k];
                        }
                    k++;
                }
            }
            while (Ok);
            return k;
        }

        struct TEdges          // временная структура для ребра
        {
            public int n1;     // № первой вершины
            public int n2;     // № второй вершины
            public int A;      // вес ребра
        }
        TEdges[] Edges;

        void SetColorEdge()
        {
            while (!Lib.myStack.isEmpty())
            {
                int t = (int)Lib.myStack.Pop(); // взять из стека № ребра
                int N = Nodes.Length;
                for (int i = 0; i <= N - 1; i++)
                {
                    int LL = 0;
                    if (Nodes[i].Edge != null)
                    {
                        LL = Nodes[i].Edge.Length;
                        for (int j = 0; j <= LL - 1; j++)
                            if (((i == Edges[t].n1) & (Nodes[i].Edge[j].numNode == Edges[t].n2)) |
                                ((i == Edges[t].n2) & (Nodes[i].Edge[j].numNode == Edges[t].n1)))
                                SetEdgeBlack(i, j); // закрасить ребро
                    }
                }
            }
        }

        bool Find(int m1, int m2)
        {
            bool Result = false;
            if (Edges == null)
                return Result;
            int N = Edges.Length; int i = -1;
            while ((i < N - 1) && !Result)
                Result = ((Edges[++i].n1 == m1) & (Edges[i].n2 == m2)) | ((Edges[i].n1 == m2) & (Edges[i].n2 == m1));
            return Result;
        }

        public void Craskal()
        {
            ClearVisit();
            Lib.myStack = new MyStack();
            int N = Nodes.Length; int m = 0;
            // формируем массив всех ребер
            for (int i = 0; i <= N - 1; i++)
            {
                int L = 0;
                if (Nodes[i].Edge != null)
                {
                    L = Nodes[i].Edge.Length;
                    for (int j = 0; j <= L - 1; j++)
                        if (!Find(i, Nodes[i].Edge[j].numNode))
                        {
                            Array.Resize<TEdges>(ref Edges, ++m);
                            Edges[m - 1].n1 = i;
                            Edges[m - 1].n2 = Nodes[i].Edge[j].numNode;
                            Edges[m - 1].A = Nodes[i].Edge[j].A;
                        }
                }
            }
            TEdges h = new TEdges();

            // Сортируем ребра графа по возрастанию весов
            for (int i = 0; i <= m - 2; i++)
                for (int j = m - 1; j >= i + 1; j--)
                    if (Edges[j].A < Edges[j - 1].A)
                    {
                        h = Edges[j]; Edges[j] = Edges[j - 1]; Edges[j - 1] = h;
                    }

            int[] Link = new int[N];
            // Вначале все ребра в разных компонентах связности
            for (int i = 0; i <= N - 1; i++) Link[i] = i;

            int numEdge = 0; // номер ребра
            int q = N - 1;       // номер вершины
            while ((numEdge <= m - 1) & (q != 0))
            {
                // если вершины в разных компонентах связности
                if (Link[Edges[numEdge].n1] != Link[Edges[numEdge].n2])
                {
                    int t = Edges[numEdge].n2;
                    Lib.myStack.Push(numEdge);   // поместить в стек номер ребра
                    for (int j = 0; j <= N - 1; j++)
                        if (Link[j] == t)
                            Link[j] = Link[Edges[numEdge].n1]; // в один компонент связности
                    q--;
                }
                numEdge++;
            }
            SetColorEdge(); // закраска ребер
        }

        void SetVisit(int i)
        {
            if (!Nodes[i].visit)
            {
                if (Nodes[i].Edge != null)
                    for (int j = 0; j <= Nodes[i].Edge.Length - 1; j++)
                    {
                        SetEdgeBlack(i, j); // закрасить ребро
                        SetVisit(Nodes[i].Edge[j].numNode);
                    }
                Lib.myStack.Push(i);
                VisitTrue(i);           // отметить песещение
            }
        }

        public void TopSort()
        {
            int N = Nodes.Length;
            ClearVisit();
            Lib.myStack = new MyStack();
            for (int i = 0; i <= N - 1; i++)
                SetVisit(i);
        }

        void SetEdgeR(int v)
        {
            if (!Nodes[v].visit)
            {
                VisitTrue(v);
                Lib.myStack.Push(v);
                int LL = 0;
                if (Nodes[v].Edge != null)
                {
                    LL = Nodes[v].Edge.Length;
                    for (int i = 0; i <= LL - 1; i++)
                        SetEdgeR(Nodes[v].Edge[i].numNode);
                }
            }
        }

        public void SetEdge(int s)
        {
            ClearVisit();
            Lib.myStack = new MyStack();
            SetEdgeR(s);
        }

    }
}
