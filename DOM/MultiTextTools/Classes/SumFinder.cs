using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;

namespace MultiTextTools.Classes
{
    class SumFinder : IModule
    {
        private static bool[] GetBinaryRepresentation(BigInteger i)
        {
            List<bool> result = new List<bool>();
            while (i > 0)
            {
                BigInteger m = i % 2;
                i = i / 2;
                result.Add(m == 1);
            }
            //result.Reverse();
            return result.ToArray();
        }
        public SumFinder()
        { }
        public string Answer(string input)
        {
            string output = "";
            string[] s0 = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] s1 = s0[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string win_text,
                   nearest_value_text = "";
            int n = s1.Length,
                win_count = 1;
            BigInteger dvoika = BigInteger.Pow(2, n);
            double[] x = new double[n];
            double y = Double.Parse(s0[1]),
                   win_value,
                   nearest_value = y;
            for (int i = 0; i < n; i++)
                x[i] = Double.Parse(s1[i]);

            for (BigInteger i = 0; i < dvoika; i++)
            {
                win_value = 0; win_text = "";
                bool[] vect = GetBinaryRepresentation(i);
                for (int j = 0; j < vect.Length; j++)
                    if (vect[j])
                    {
                        win_text += s1[j]+" ";
                        win_value += x[j];
                    }
                if (win_value == y)
                {
                    output += win_count++ + ") " + win_text + Environment.NewLine;
                    if (dvoika>Int32.MaxValue)
                        return output+ "Выведен только первый найденный вариант, это "+i+" из "+dvoika+" вариантов!";
                }
                else
                    if (Math.Abs(y - win_value) < nearest_value)
                {
                    nearest_value = win_value;
                    nearest_value_text = "" + win_text;
                }
            }
            if (output == "")
                return "Из " + dvoika + " вариантов ничего не найдено! Ближающий вариант - сумма " +
                    nearest_value + "(разница ="+(y-nearest_value)+") из чисел " + nearest_value_text;
            return output;
        }
        public string Name()
        { return "Находитель суммы"; }
        public string Tip()
        { return "Перебором находит из чисел (перечисление через пробел) в первой строке сумму, чтобы получить число во второй строке."; }
    }
}

