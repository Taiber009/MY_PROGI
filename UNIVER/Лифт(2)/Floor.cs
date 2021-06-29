using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лифт_2_
{
    class Floor
    {
        public Queue<Man> ManQueue = new Queue<Man>(); //очередь ожидающий лифт на этаже
        public string Who = ""; //стринговая строка всех ожидающий лифт на этом этаже (для ячейки в Grid)
        public void NewUser(Man m) //добавляем нового человека, ожидающего лифт
        {
            ManQueue.Enqueue(m);
            int f = m.Target+1;
            Who = ' '+m.Name + '(' + f + ")" + Who;
        }
        public Man DeleteUser() //удаляем одного человека, ожидающего лифт
        {
            string s = "", s1 = "";
            int c = ManQueue.Count-1;
            s += Who;
            for (int j = 0; (j < s.Length)&&(c>0); j++)
            {
                s1 += s[j];
                if (s[j+1] == ' ')
                    --c;       
            }
            Who = s1;
            return ManQueue.Dequeue(); //еще выводим его в массив пользователей лифта
        }
        
    }
}
