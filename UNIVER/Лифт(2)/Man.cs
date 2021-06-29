using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лифт_2_
{
    class Man
    {
        public string Name; //имя
        public int Floor; //на каком этаже сейчас
        public bool Here; //уже ждет/едет в лифте?(чтобы не спавнить второго такого-же человека)
        public int Target; //на какой этаж едет
        public Man(string n, int f) //конструктор
        {
            Name = n;
            Here = false;
            Floor = f;
        }
    }
}
