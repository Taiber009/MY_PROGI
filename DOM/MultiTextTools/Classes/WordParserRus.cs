using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiTextTools.Classes
{
    class WordParserRus : IModule
    {
        public WordParserRus()
        { }
        bool FullCheck(char c)
        {
            if ((c >= 1040 && c <= 1103) || (c == 1025) || (c == 1105) || c == '-')
                return true;
            else
                return false;
        }
        bool LowerCheck(char c)
        {
            if ((c >= 1072 && c <= 1103) || (c == 1105))
                return true;
            else
                return false;
        }
        bool FirstBracketsCheck(char c)
        {
            if (c == '"' || c == '(' || c == '[' || c == '{' || c == '*')
                return true;
            else
                return false;
        }
        bool LastPunctuationMarkCheck(char c, int i, int l)
        {
            if (i == l - 1 && (c == '.' || c == '?' || c == '!' || c == '"' || c == ')' || c == ']' || c == '}' || c == ',' || c == '*' || c == ':' || c == ';' || c == '>'))
                return true;
            else
                return false;
        }
        public string Answer(string input)
        {
            //границы алфавита
            //А = 1040
            //Я = 1071
            //а = 1072
            //я = 1103
            //Ё = 1025
            //ё = 1105
            string output = "";
            string[] s = input.Split(new string[] { "\n", " " }, StringSplitOptions.RemoveEmptyEntries),
                     win = new string[s.Length];
            int winIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                bool stop = false;
                if (FirstBracketsCheck(s[i][0]))
                {
                    s[i] = s[i].Substring(1);
                    if (s[i] == "")
                        continue;
                }
                if (FullCheck(s[i][0]))
                {
                    if (LowerCheck(s[i][0]))
                    {
                        if (s[i][0] == 1105)
                            s[i] = "Ё" + s[i].Substring(1);
                        else
                            s[i] = "" + (char)((int)s[i][0] - 32) + s[i].Substring(1);
                    }
                }
                else
                    continue;
                int len = s[i].Length;
                for (int j = 1; j < len; j++)
                {
                    if (!FullCheck(s[i][j]) && !LastPunctuationMarkCheck(s[i][j], j, len))
                    {
                        stop = true;
                        break;
                    }
                    else
                        if (LastPunctuationMarkCheck(s[i][j], j, len))
                            s[i] = s[i].Substring(0, j);
                }

                if (s[i].Length < 5)
                    continue;

                if (!stop)
                {
                    bool stop2 = false;
                    for (int j = 0; j < winIndex; j++)
                    {
                        if (win[j] == s[i])
                        {
                            stop2 = true;
                            break;
                        }
                    }
                    if (!stop2)
                    {
                        win[winIndex++] = s[i];
                    }
                }
            }
            for (int i = 0; i < winIndex; i++)
                output += win[i] + Environment.NewLine;
            return output;
        }
        public string Name()
        { return "Парсер слов (Rus, >=5)"; }
        public string Tip()
        { return "Парсит слова из русского текста в одном экземпляре, первую букву делает заглавной, слова с менее 5 букв не учитываются."; }
    }
}
