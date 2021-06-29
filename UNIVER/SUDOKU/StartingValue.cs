using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SUDOKU
{
    struct StartingValue //заменить на класс???
    {
        public int x;
        public int y;
        public int val;
        public StartingValue(int value,int x, int y )
        {
            this.val = value;
            this.x = x;
            this.y = y;

        }
    }
}
