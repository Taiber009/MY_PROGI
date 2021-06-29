using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Химия_3_
{
    public class Element : Izachem
    {
        protected string name;
        protected double weight;
        protected int charge;
        public string Name()
        {
            return name;
        }
        public double Weight()
        {
            return weight;
        }
        public int Charge()
        {
            return charge;
        }
    }
}
