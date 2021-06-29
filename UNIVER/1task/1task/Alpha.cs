using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1task
{
    class Alpha
    {
        /*Напишите процедуру сортировки строк в обратном алфавитном порядке.*/
        public static void BackAlphabet(ref string[] s)
        {
            int i,j;
            string x;
            for (i = 0; i < s.Length;i++)
            {
                for (j = 0; j < i;j++)
                {
                    if (Pro(s[i], s[j]))
                    {
                        x = s[i];
                        s[i] = s[j];
                        s[j] = x;
                    }
                }
            }            
        }
        protected static bool Pro(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
    }
}
