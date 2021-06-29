using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace MultiTextTools.Classes
{
    class Sorter:IModule
    {
        public Sorter()
        { }
        public string Answer(string input)
        {
            string temp,
                   output="";
            string[] s = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    int min;
                    if (s[j - 1].Length < s[j].Length)
                        min = s[j - 1].Length;
                    else
                        min = s[j].Length;
                    for (int k = 0; k < min; k++)
                    {
                        if (s[j - 1][k] < s[j][k])
                            break;
                        if (s[j - 1][k] > s[j][k])
                        {
                            temp = s[j - 1];
                            s[j - 1] = s[j];
                            s[j] = temp;
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < s.Length; i++)
                output += s[i] + Environment.NewLine;
            return output;
        }
        public string Name()
        { return "Сортировщик"; }
        public string Tip()
        { return "Сортирует слова, перечисление слов в столбик."; }
    }
}
