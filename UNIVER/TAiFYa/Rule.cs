using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace TAiFYa
{
    class Rule
    {
        public Symbol left;
        public Symbol[] right;

        public Rule(Symbol l, Symbol[] r)
        {
            left = l;
            right = r;
        }
        public string TextFull()
        {
            string s = "" + left.value + " → ";
            for (int i = 0; i < right.Length; i++)
                s += right[i].value;
            return s;
        }

        public string TextRightPart()
        {
            string s = "" ;
            for (int i = 0; i < right.Length; i++)
                    s += right[i].value;
            return s;
        }
    }
}
