using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Химия_3_
{
    public class Atoms:Izachem
    {
        public Element[] Els;
        private string name;
        //private double weight;
        //public int charge;
        public int count;
        public int Pcount;
        public int Ecount;
        public int Ncount;
        public Atoms(string Name, int P, int E, int N)
        {
            Els = new Element[P + E + N];
            int i = 0, j;
            for (j = 0; j < P; i++, j++)
                Els[i] = new Elements.Proton();
            for (j = 0; j < E; i++, j++)
                Els[i] = new Elements.Electron();
            for (j = 0; j < N; i++, j++)
                Els[i] = new Elements.Neutron();
            name = Name;
            //weight = 0;
            //charge = 0;
            count = 1;
            Pcount = P;
            Ecount = E;
            Ncount = N;
            //foreach (Element e in Els)
            //{
                //weight += e.Weight();
                //charge += e.Charge();
            //}
        }
        public Atoms(string Name, int P, int E, int N, int Count)
        {
            Els = new Element[P + E + N];
            int i = 0, j;
            for (j = 0; j < P; i++, j++)
                Els[i] = new Elements.Proton();
            for (j = 0; j < E; i++, j++)
                Els[i] = new Elements.Electron();
            for (j = 0; j < N; i++, j++)
                Els[i] = new Elements.Neutron();
            name = Name;
            //weight = 0;
            //charge = 0;
            count = Count;
            Pcount = P;
            Ecount = E;
            Ncount = N;
            //foreach (Element e in Els)
            //{
                //weight += e.Weight();
                //charge += e.Charge();
            //}
        }
        public Atoms(Atoms A)//перегрузка конструктора для копирования, тк ссылочный тип данных
        {
            name = A.name;
            //weight = A.weight;
            //charge = A.charge;
            count = A.count;
            Pcount = A.Pcount;
            Ecount = A.Ecount;
            Ncount = A.Ncount;
            Els = new Element[A.Els.Length];
            for (int i = 0; i < Els.Length; i++)
                if (A.Els[i].Charge() == 1)
                    Els[i] = new Elements.Proton();
                else if (A.Els[i].Charge() == 0)
                    Els[i] = new Elements.Neutron();
                else
                    Els[i] = new Elements.Electron();
        }
        public string Name()//зачем все это?!
        {
            return name;
        }
        public double Weight()
        {
            double we=0;
            foreach (Element e in Els)
            {
                we += e.Weight();
            }
            return we*count;
 
        }
        public int Charge()
        {
            int ch = 0;
            foreach (Element e in Els)
            {
                ch += e.Charge();
            }
            return ch * count; 
        }
    }
}
