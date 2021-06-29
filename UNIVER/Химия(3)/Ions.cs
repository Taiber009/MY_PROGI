using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Химия_3_
{
    public class Ions:Izachem
    {
        //public int x;//заряд
        public int count;//сколько таких ионов в молекуле
        public Atoms[] Ats;
        public int p;
        //public int ac;
        //public double weight;
        //public int charge;
        public Ions()
        {
            Ats = new Atoms[0];
            count = 1;
            p = 0;
            //ac = 0;
            //weight = 0;
            //charge = 0;
        }
        public Ions(Ions I)//перегрузка конструктора для копирования, тк ссылочный тип данных
        {
            Ats = new Atoms[I.Ats.Length];
            count = I.count;
            p = I.p;
            //ac = I.ac;
            for (int i = 0; i < I.Ats.Length; i++)
            {
                Ats[i] = new Atoms(I.Ats[i]);//такой же конструктор
                //weight += Ats[i].weight * Ats[i].count;
                //charge += Ats[i].charge * Ats[i].charge;
            }
        }
        public int Charge()
        {
            int c=0;
            foreach(Atoms a in Ats)
                c+=a.Charge();
            return c*count;

        }
        public double Weight()
        {
            double w = 0;
            foreach (Atoms a in Ats)
                w += a.Weight();
            return w*count;
        }
        public void New(Atoms A)
        {
            bool new_atom = true;
            //x += A.charge;
            //for (int i = 0; i < p; i++)
            foreach (Atoms i in Ats)
                if (i.Name() == A.Name())
                {
                    i.count++;
                    new_atom = false;
                    break;
                }
            if (new_atom)
            {
                // if (p >= pos.Length)
                Array.Resize<Atoms>(ref Ats, p + 1);
                Ats[p] = new Atoms(A);
                p++;
            }
        }
        public string Name()
        {
            string s="";
            foreach (Atoms A in Ats)
                if (A.count == 1)
                    s += A.Name();
                else
                    s += A.Name() + A.count;
            return s;
        }
        /*
        private string Select(Ions I)
        {
            if (I.y == 1)
                return I.name;
            else if (I.y > 1)
                if (num.Contains(I.name[I.name.Length - 1]) || I.name == "OH")
                    return '(' + I.name + ')' + I.y;
                else
                    return I.name + I.y;
            return "";
        }
        */
    }
}
