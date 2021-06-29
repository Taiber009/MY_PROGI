using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Химия_3_
{
    public class Mol:Izachem
    {
        public Ions pos;
        public Ions neg;
        //private int p, n;
        //public int chargeP, chargeN;
        private HashSet<char> num = new HashSet<char>();
        public Mol()
        {
            pos = new Ions();
            neg = new Ions();
            //p = 0;n = 0;
            //chargeP = 0;
            //chargeN = 0;
            for (int i = 48; i < 58; i++)
                num.Add((char)i);
        }
        public string Name()
        {
            string s = "";
            //bool p = pos.Ats.Length > 1 && pos.count > 1,
            //     n = neg.Ats.Length > 1 && neg.count > 1;//проверка на необходимость скобок
            int nod = NOD((double)pos.count, (double)neg.count);//int???
            if (nod > 1) s += nod;

            double newCount = (double)pos.count / nod;
            if (pos.Ats.Length > 1 && newCount > 1) s += '(';
            foreach (Atoms a in pos.Ats)
                s += Select(a);
            if (pos.Ats.Length > 1 && newCount > 1) s += ")";
            if (newCount > 1) s += newCount;

            newCount = neg.count / nod;
            if (neg.Ats.Length > 1 && newCount > 1) s += '(';
            foreach (Atoms a in neg.Ats)
                s += Select(a);
            if (neg.Ats.Length > 1 && newCount > 1) s += ")";
            if (newCount > 1) s += newCount;

            return s+" (Weight:"+Weight()+", Charge:"+Charge()+")";
        }
        private string Select(Atoms a)
        {
            if (a.count == 1)
                return a.Name();
            else if (a.count > 1)
                if (num.Contains(a.Name()[a.Name().Length - 1]) /*|| a.name == "OH"*/)
                    return '(' + a.Name() + ')' + a.count;
                else
                    return a.Name() + a.count;
            return "";
        }
        private int NOD(double x, double y)
        {
            int win = 1; 
            double z;
            if (x >= y) z = y;
            else        z = x;
            for (int i = 1; i <= z; i++)
                if (x % i == 0 && y % i == 0)
                    win = i;
            return win;
        }
        public double Weight()
        {
            return neg.Weight() + pos.Weight();
        }
        public int Charge()
        {
            return neg.Charge() + pos.Charge();
        }
        /*
        public string SelectP(Mol M, int i)
        {
            if (M.pos[i].y != 1)
                return M.pos[i].name + M.pos[i].y;
            else
                return M.pos[i].name;
        }
        public string SelectN(Mol M, int i)
        {
            if (M.neg[i].y != 1)
                return M.neg[i].name + M.neg[i].y;
            else
                return M.neg[i].name;
        }
         */
    }
}
