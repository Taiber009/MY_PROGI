using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiTextTools.Classes
{
    class WordParserFull : IModule
    {
        public WordParserFull()
        { }
        bool FullCheck(char c)
        {
            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || c == '\'' || c == '-')
                return true;
            else
                return false;
        }
        bool LowerCheck(char c)
        {
            if (c >= 97 && c <= 122)
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
            //A = 65
            //Z = 90
            //a = 97
            //z = 122
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
        { return "Парсер слов (Eng, Full)"; }
        public string Tip()
        { return "Парсит слова из английского текста в одном экземпляре, первую букву делает заглавной, учитываются все слова."; }
    }
}
