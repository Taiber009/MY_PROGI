using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Задача_5_
{
    class Node
    {
        Node[] childs;
        string key, value;
    }
    class Kod
    {
        public static StreamReader f;
        static string PoiskString(string[] Keys, int KeyN)
        {
            int i = 0;
            string s="", s1 = "";
            bool proverka = true, proverka2=false;
            while (!proverka2)
            {
                s = f.ReadLine();
                if (s == null)
                    return '"' + "Нет такой строки" + '"';      
                for (i = 0; i < KeyN * 2; i++)
                {
                    if (i>=s.Length)
                        return '"' + "Нет такой строки" + '"';
                    if (s[i] != ' ')
                        proverka = false;
                }
                if (proverka)
                {
                    s1 = "";
                    for (i=i; i < s.Length; i++)
                    {
                        if (s[i] == ':')
                        {
                            break;
                        }
                            s1 += s[i];
                    }
                    if (s1 == Keys[KeyN])
                        proverka2=true;
                }
                else
                {
                    proverka = true;
                }
                
            }
            if (KeyN == (Keys.Length - 1))
                return s;
            return PoiskString(Keys, KeyN+1);
        }
        /*public string findString(string dictionary, string[] keys, int keyN, ref int index)
        {
        }*/
        

        public static string translate(string lang, string x)
        {
            int i=0,KeyN=0;
            string win = "",y="";
            x = lang + "." + x + ".";
            while (i < x.Length)
            {
                if (x[i] == '.')
                    KeyN++;
                i++;
            }
            string[] Keys = new string[KeyN];

            i = 0;
            KeyN = 0;
            while (i < x.Length)
            {
                if (x[i] != '.')
                {
                    y += x[i];
                }
                else
                {
                    Keys[KeyN] = y;
                    KeyN++;
                    y = "";
                }
                i++;
            }
            i = 0;
            x = PoiskString(Keys, 0);
            KeyN = 0;
            while (KeyN<2)
            {
                if (i >= x.Length)
                {
                    return "Там ничего нет или некорректно введен адрес!";
                }
                if ((x[i] == '"') && (KeyN == 1))
                    return win;
                if ((x[i] != '"') && (KeyN == 1))
                    win += x[i];
                if (x[i] == ':')
                {
                    KeyN++;
                    i+=2;
                }
                i++;
            }
            return "Не нашел : в конце адреса";
        }
    }
}
