using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace MultiTextTools.Classes
{
    class Combiner : IModule
    {
        public Combiner()
        { }
        public string Answer(string input)
        {
            string output = "";
            string[] s0 = input.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries),
                s1 = s0[0].Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries),
                s2 = s0[1].Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (s1.Length > s2.Length)
                Array.Resize<string>(ref s2, s1.Length);
            else if (s2.Length > s1.Length)
                Array.Resize<string>(ref s1, s2.Length);
            for (int i = 0; i < s1.Length; i++)
                output += s1[i] + " – " + s2[i] + "\n";
            return output;
        }
        public string Name()
        { return "Сопоставлятор"; }
        public string Tip()
        { return "Сопоставляет 2 столбца, разделение столбцов через пустую строку."; }
    }
}
