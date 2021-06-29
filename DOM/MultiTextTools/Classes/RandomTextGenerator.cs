using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiTextTools.Classes
{
    class RandomTextGenerator : IModule
    {
        public RandomTextGenerator()
        { }
        public string Answer(string input)
        {
            string[] s = input.Split('\n');
            int lenText = 0,
                lenDic = s.Length - 1;
            if (!Int32.TryParse(s[0], out lenText))
                return "Ошибка формата!";
            string output = "";
            string[] dic = new string[lenDic];
            Random rand = new Random();

            for (int i = 0; i < lenDic; i++)
                dic[i] = s[i+1];
            for (int i = 0; i < lenText; i++)
                output += dic[rand.Next(0, lenDic)]+" ";
                return output;
        }
        public string Name()
        { return "Генератор рандомного текста"; }
        public string Tip()
        { return "Генерирует рандомный текст на основе введенной длины текста (первая строка) и словаря слов (по 1 слову на строку, начиная со второй)."; }
    }
}
