using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        public struct Student
        {
            public Int64 a;//уровень знаний алгоритмов
            public Int64 b;//опыт, необходимый при подсчете в конце, когда наберем нужных студентов
        }
        public struct GroupOfStudent  //тут была попытка реализовать наследование...
        {
            public Int64 a;
            public Int64 b;
            public bool[] binar;//бинарный код значения a (уровня знаний алгоритмов)
            public GroupOfStudent(Student s)
            {
                a = s.a;
                b = s.b;
                binar = GetBinaryRepresentation(a); 
            }
        }

        public static bool Test(bool[] x, bool[] y)
        {
            int len;
            if (y.Length <= x.Length)
                len = y.Length;
            else
                return false;
            for (int i = 0; i < len; i++)
                if (!x[i] && y[i])//если j(y) знает алгоритм, который не знает i(x)
                    return false;
            return true;
        }
        private static bool[] GetBinaryRepresentation(Int64 i) //перевод из 10 в 2
        {
            List<bool> result = new List<bool>();
            while (i > 0)
            {
                Int64 m = i % 2;
                i = i / 2;
                result.Add(m == 1);
            }
            //result.Reverse();
            return result.ToArray();
        }
        static void Main(string[] args)//https://codeforces.com/contest/1229/problem/A
        {
            int n = Int32.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine(0);
            else
            {
                Student[] students = new Student[n];
                Int64[] a = new Int64[n];
                string[] input = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    students[i].a = Int64.Parse(input[i]);
                    a[i] = Int64.Parse(input[i]);
                }
                input = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    students[i].b = Int64.Parse(input[i]);
                }
                Array.Sort(students, (x, y) => x.a.CompareTo(y.a));//Array.Sort(c, (x, y) => x.time2die.CompareTo(y.time2die));
                Array.Reverse(students);//в убывающем порядке
                int newstart = -1;
                for (int i = 0; i < n - 1; i++)
                    if (students[i].a == students[i + 1].a)//ищем первую пару лучших (они компенсируют друг друга)
                    {
                        newstart = i;
                        break;
                    }
                if (newstart == -1)//все одиночки = не найдем как минимум пару, где оба не считают себя лучшими
                    Console.WriteLine(0);
                else
                {
                    GroupOfStudent[] students_groups = new GroupOfStudent[n];//массив групп студентов с одним уровнем знаний (опыт суммируется)
                    bool[] students_groups_notSingleton = new bool[n];//в каких группах по 1 студенту, а в каких больше 1 (вторые всегда проходят)
                    int students_groups_number = 0;//пока не знаем, сколько групп студентов с одним уровнем знаний
                    students_groups[students_groups_number/*0*/] = new GroupOfStudent(students[newstart]);

                    for (int i = newstart + 1; i < n; i++)
                        if (students[i].a == students_groups[students_groups_number].a)//группируем студентов с одним уровенем знаний
                        {
                            students_groups_notSingleton[students_groups_number] = true;//группа-неодиночек
                            students_groups[students_groups_number].b += students[i].b;
                        }
                        else
                            students_groups[++students_groups_number] = new GroupOfStudent(students[i]);//новая группа
                    ++students_groups_number;

                    List<GroupOfStudent> finalGroup = new List<GroupOfStudent>();

                    for (int i = 0; i < students_groups_number; i++)
                    {
                        if (students_groups_notSingleton[i])//если это группа-неодиночек
                            finalGroup.Add(students_groups[i]);//то мы их добавляем в финальную группу, они не будут считать себя лучшими, тк сами себя компенсируют
                    }
                    for (int i = 0; i < students_groups_number; i++)
                    {
                        if (!students_groups_notSingleton[i])//если это одиночка
                            for (int j = 0; j < finalGroup.Count; j++)
                                if (Test(finalGroup[j].binar, students_groups[i].binar))//если кто-то из уже отобранных студентов умнее его...
                                {//(идем от умных к глупым, поэтому, если студент "самый умный", то дальше не будет студентов умнее его)
                                    finalGroup.Add(students_groups[i]);//...то мы добавляем его в финальную группу
                                    break;
                                }
                    }

                    Int64 win = 0;
                    for (int i = 0; i < finalGroup.Count; i++)
                        win += finalGroup[i].b;
                    Console.WriteLine(win);
                }
            }
        }
    }
}
