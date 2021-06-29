using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAiFYa
{
    class Symbol
    {
        public char value;
        public bool terminal;

        public Symbol(char v,bool t)
        {
            value = v;
            terminal = t;
        }
    }
}
