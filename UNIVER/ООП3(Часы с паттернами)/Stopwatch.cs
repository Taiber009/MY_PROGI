using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП3__Часы_с_паттернами_
{
    class Stopwatch
    {
        public int time;//хватит на 600 часов таймера!
        public int multiplier;
        //public bool enb;
        public Stopwatch()
        {
            time = 0;
            multiplier = 1;
            //enb = false;
        }
        public void Change()
        {
            multiplier *= -1;
        }
        public string TimerString()
        {
            return time / 60000 + ":" + (time % 60000) / 1000 + "," + (time % 1000)/10;
        }
    }
}
