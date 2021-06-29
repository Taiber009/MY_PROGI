using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10._6
{
    class Kod
    {
        public static string go(char a)
        {
            char i;
            HashSet<char> Eng = new HashSet<char>();
            HashSet<char> Rus = new HashSet<char>();
            for (i = 'A'; i <= 'Z'; i++)
                Eng.Add(i);
            for (i = 'a'; i <= 'z'; i++)
                Eng.Add(i);
            for (i = 'А'; i <= 'Я'; i++)
                Rus.Add(i);
            for (i = 'а'; i <= 'я'; i++)
                Rus.Add(i);
            
            Rus.Add('ё');
            Rus.Add('Ё');

            if (Eng.Contains(a))
                return "Набран символ " + a + " на английском регистре";
            if (Rus.Contains(a))
                return "Набран символ " + a + " на русском регистре";
            return "Набран символ " + a + ", который не является символом русского или английского регистра";
        }
    }
}
