using System;
using System.Text;

namespace OOP1
{
    /*
    class Kod
    {

        // Mylist<int> list = Mylist<int();
    }*/
    public class MyExp : Exception
    {
        public MyExp(string mes)
            : base(mes)
        {

        }
        public MyExp NotEq(int x,int y,string s)
        {
            return null;// "Не равны элементы *" + s + "* (" + x + " и " + y + ")";
        }

    }/*
    public class Mylist<T> where T : IComparable
    {
        private int c;
        private T[] elem;
        public void Add(T val)
        {

        }
        public T get(int i)
        {
            throw new MyExp("...");
        }
    }*/
}

