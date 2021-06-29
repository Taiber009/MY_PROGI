using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SUDOKU
{
    class MyTimer
    {
        public int time;//хватит на 600 часов таймера!
        //public bool enb;
        public MyTimer()
        {
            time = 0;
            //enb = false;
        }
        public string TimerString()
        {
            return time / 60000 + ":" + (time % 60000) / 1000;
        }
    }
}
