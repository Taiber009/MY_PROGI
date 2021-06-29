using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSort
{
    class Sort
    {
        public static byte flTools = 0;
        public static int n = 20;
        public static int n1000 = 400;
        public static int Count;
        public static int[] a = new int[n];
        public static int[] b = new int[n];
        static Random rnd = new Random();
        public static int MaxA;

        public static void SetArr()
        {
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(100);
            a[n-1] = a[0];
        }

        public static int[] countA1 = new int[n1000];
        public static int[] countA2 = new int[n1000];
        public static int[] countB1 = new int[n1000];
        public static int[] countB2 = new int[n1000];
       
        public static void SortBubl()
        {
            for (int i = 1; i <= n - 1; i++)
                for (int j = n - 1; j >= i; j--)
                {
                    countA1[n]++;
                    if (countA1[n] > MaxA)
                        MaxA = countA1[n];
                    if (b[j - 1] > b[j])
                    {
                        countA2[n]++;
                        int t = b[j - 1];
                        b[j - 1] = b[j];
                        b[j] = t;
                    }
                }
        }

        public static void NoRecurs() // Без рекурсии
        {
            int left = 0; int right = b.Length - 1;
            MyStack stack = new MyStack();
            T LRRange = new T(left, right);
            stack.PushStack(LRRange);

            while (!stack.StackIsEmpty())
            {
                LRRange = stack.PopStack();
                left = LRRange.l;
                right = LRRange.r;
                while (left < right)
                {
                    int i = left, j = right, x = b[(left + right) / 2];
                    while (i <= j)
                    {
                        countB1[n]++;
                        while (b[i] < x) i++;
                        while (b[j] > x) j--;
                        if (i <= j)
                        {
                            int tmp = b[i]; b[i] = b[j];
                            b[j] = tmp;
                            i++; j--;
                            countB2[n]++;
                        }
                    }


                    if (j - left < right - i)
                    {
                        if (i < right)
                        {
                            LRRange.l = i; LRRange.r = right;
                            stack.PushStack(LRRange);
                            countB1[n]++;
                        }
                        right = j;
                    }
                    else
                    {
                        if (left < j)
                        {
                            LRRange.l = left; LRRange.r = j;
                            stack.PushStack(LRRange);
                            countB1[n]++;
                        }
                        left = i;
                    }
                }
            }
        }

        public static void Recurs(int left, int right)//рекурсия
        {
            int i = left; int j = right;
            int x = b[(left + right) / 2];
            do
            {
                while (b[i] < x)
                {
                    i++;
                    countB1[n]++;
                }
                while (b[j] > x)
                {
                    j--;
                    countB1[n]++;
                }
                if (i <= j)
                {
                    int tmp = b[i];
                    b[i] = b[j];
                    b[j] = tmp;
                    i++; j--;
                    countB2[n]++;
                }
            }
            while (i <= j);
            if (left < j)
                Recurs(left, j);
            if (i < right)
                Recurs(i, right);
        }

      





        /*public static void SortSelection2() // простым выбором
        {
            for (int i = 0; i <= n - 2; i++)
            {

                int imin = i;
                for (int j = i + 1; j <= n - 1; j++)  // в этом цикле ищем  минимальный элемент
                {
                    countB1[n]++;
                    if (b[j] < b[imin]) imin = j;
                }
                if (i != imin)
                {
                    countB2[n]++;
                    int tmp = b[imin]; // обмен местами мин. элемента с первым
                    b[imin] = b[i];    // из оставшейся – не отсортированной
                    b[i] = tmp;        // – части массива
                }
            }
        }

        public static void SortInsertion() // простыми включениями
        {
            Count = 0;
            for (int i = 0; i < n; i++)
            {
                // перебор входного массива
                // поиск места для a[i] в выходном массиве
                int j = 0;
                while ((j < i) & (b[j] <= a[i]))
                {
                    countB2[n]++;
                    j = j + 1;
                }
                // освобождение места для нового эл-та
                for (int k = i; k >= j + 1; k--)
                {
                    countB1[n]++;
                    b[k] = b[k - 1];
                    Count = Count + 1;
                }
                b[j] = a[i];        // запись в выходной массив
            }
        }

        public static void SortBinInsert() // бинарными включениями
        {
            for (int i = 0; i <= n - 1; i++)
            {
                int tmp = b[i]; int left = 0; int right = i - 1;
                while (left <= right)
                {
                    countB1[n]++;
                    int m = (left + right) / 2; //определение индекса среднего элемента
                    countB2[n]++;
                    if (tmp < b[m])
                        right = m - 1;  // сдвиг правой 
                    else 
                        left = m + 1;   //или левой границы
                }
                for (int j = i - 1; j >= left; j--)
                {
                    countB1[n]++;
                    b[j + 1] = b[j];    // сдвиг элементов
                }
                b[left] = tmp;          // вставка элемента на нужное место
            }
        }

        public static void SortShell() // Шелла
        {
            Count = 0;
            int d = n / 2; // начальное значение интервала
            while (d > 0)  // цикл с уменьшением интервала до 1
            {
                bool Ok = true; // пузырьковая сортировка с интервалом d
                while (Ok)      // цикл, пока есть перестановки
                {
                    Ok = false;
                    for (int i = 0; i < n - d; i++) // сравнение эл-тов на интервале d
                    {
                        countB1[n]++;
                        if (b[i] > b[i + d])
                        {
                            countB2[n]++;
                            int t = b[i]; b[i] = b[i + d]; b[i + d] = t; // перестановка
                            Ok = true; // признак перестановки
                            Count++;
                        }
                    }
                }
                d = d / 2;    // уменьшение интервала
            }
        }

        public static int[] count;

        public static void SortCount() // ПОДСЧЕТОМ
        {
            count = new int[n];                  // массив счетчиков
            for (int i = 0; i < n; i++) 
                count[i] = 0;                          // инициализация массива счетчиков
            for (int i = 0; i < n; i++)              // сравнение элементов
                for (int j = i + 1; j < n; j++)      // и заполнение массива счетчиков 
                {
                    countB1[n]++;
                    countB2[n]++;
                    if (a[i] > a[j])
                        count[i] = count[i] + 1;
                    else
                        count[j] = count[j] + 1;
                }
            for (int i = 0; i < n; i++)              // пересылка элементов в новый массив
                b[count[i]] = a[i];
        }*/

        public static void Сравнить()
        {
            MaxA = 0; //MaxB = 0;
            for (int i = 0; i < n1000; i++)
            {
                countA1[i] = 0;
                countA2[i] = 0;
                countB1[i] = 0;
                countB2[i] = 0;
            }

            for (n = 10; n < n1000; n++)
            {
                a = new int[n];
                b = new int[n];
                SetArr();
                for (int i = 0; i <= n - 1; i++)
                    b[i] = a[i];
                SortBubl();
                for (int i = 0; i <= n - 1; i++)
                    b[i] = a[i];

                switch (Sort.flTools)
                {
                    case 1:
                        NoRecurs();
                        break;
                    case 2:
                        Recurs(0, b.Length - 1);
                        break;
                }
            }
        }
        
        struct T
        {
            public int l;
            public int r;
            public T(int l, int r)
            {
                this.l = l; this.r = r;
            }
        }
        class MyNode
        {
            public T inf;
            public MyNode next;
            public MyNode(T inf, MyNode next)
            {
                this.inf = inf;
                this.next = next;
            }
        }
        class MyStack
        {
            MyNode head;
            public MyStack()
            {
                head = null;
            }
            public bool StackIsEmpty()
            {
                return head == null;
            }
            public void PushStack(T inf)
            {
                MyNode p = new MyNode(inf, head);
                head = p;
            }
            public T PopStack()
            {
                T k = head.inf;
                head = head.next;
                return k;
            }
        }
    }
    }

