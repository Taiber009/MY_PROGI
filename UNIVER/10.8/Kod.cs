using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._8
{
    class Kod
    {
        public static string go(char a)
        {
            int i;
            HashSet<char> Eng = new HashSet<char>();
            HashSet<char> Rus = new HashSet<char>();
            for (i = 65; i < 127; i++)
                Eng.Add((char)i);
            for (i = 1040; i < 1104; i++)
                Rus.Add((char)i);
            for (i = 43; i < 60; i++)
            {
                Eng.Add((char)i);
                Rus.Add((char)i);
            }
            Rus.Add((char)203);
            Rus.Add((char)235);

            if ((Eng.Contains(a)) && (Rus.Contains(a)))
                return "Набран символ " + a + " на русском или английском регистре";
            if (Eng.Contains(a))
                return "Набран символ " + a + " на английском регистре";
            if (Rus.Contains(a))
                return "Набран символ " + a + " на русском регистре";
            return "Набран символ " + a + ", который не является символом русского или английского регистра";
        }
    }
}
