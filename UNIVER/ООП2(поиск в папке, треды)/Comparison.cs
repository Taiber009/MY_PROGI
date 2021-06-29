using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ООП2
{
    class Comparison
    {
        //string[] load;
        //string s;
        public bool win = false;
        string x;
        string y;
        public Comparison()
        {
            x = "";
            y = "";
        }
        public Comparison(string[] load, string poisk)
        {
            x = Union(load);
            y = poisk;
            //Thread t = new Thread(Otvet);
            //t.Start(new string[]{Union(load), poisk});
            //while (!t.IsAlive);
            //t.sleep(1);
        }
        string Union(string[] m)
        {
            string s = "";
            for (int i = 0; i < m.Length; i++)
            {
                s += m[i];
                if (i < m.Length - 1) s += "\r\n";
            }
            return s;
        }
        public void Start()
        {
 
        }
        public void Otvet()
        {
            //x = Union(load); y = poisk;
            //string[] s2 = (string[])s1;
            if (x == y) 
                win = true;
        }
    }
}
