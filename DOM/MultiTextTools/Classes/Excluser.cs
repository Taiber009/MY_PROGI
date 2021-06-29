using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace MultiTextTools.Classes
{
    class Excluser : IModule
    {
        public Excluser()
        { }
        public string Answer(string input)
        {
            string output = "";
            string[] s0 = input.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (s0.Length != 2)
                return "Ошибка: введено не 2 столбца!";
            string[] s1 = s0[0].Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] s2 = s0[1].Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < s1.Length; i++)
            {
                bool itsnew = true;
                for (int j = 0; j < s2.Length;j++ )
                {
                    if(s1[i]==s2[j])
                    {
                        itsnew = false;
                        break;
                    }
                }
                if(itsnew)
                output += s1[i] + "\n";
            }
            return output;
        }
        public string Name()
        { return "Исключатор"; }
        public string Tip()
        { return "Исключает из первого столбца слова из второго, разделение столбцов через пустую строку."; }
    }
}
