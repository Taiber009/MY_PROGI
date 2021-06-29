using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP1
{
    class Complex
    {
        public double Re;
        public double Im;
        public Complex()
        {
            Re = 0;
            Im = 0;
        }
        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }
        public override string ToString()
        {
            if (Im > 0)
                if (Im!=1) return Re + "+" + Im + "i";
                else       return Re + "+i";
            else if (Im < 0)
                if (Im!=-1)return Re + "-" + Im + "i";
                else       return Re + "-i";
            else return Re + "";
        }
        
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c0 = new Complex();
            c0.Re = c1.Re + c2.Re;
            c0.Im = c1.Im + c2.Im;
            return c0;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c0 = new Complex();
            c0.Re = c1.Re - c2.Re;
            c0.Im = c1.Im - c2.Im;
            return c0;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c0 = new Complex();
            c0.Re = c1.Re * c2.Re - c1.Im * c2.Im;
            c0.Im = c1.Re * c2.Im + c2.Re * c1.Im;
            return c0;
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c0 = new Complex();
            c0.Re = (c1.Re * c2.Re + c1.Im * c2.Im) / (c2.Re * c2.Re + c2.Im * c2.Im);
            c0.Im = (c1.Im * c2.Re - c1.Re * c2.Im) / (c2.Re * c2.Re + c2.Im * c2.Im);
            return c0;
        }
        public static Complex operator +(int c1, Complex c2)
        {
            Complex c0 = new Complex();
            c0.Re = c1 + c2.Re;
            c0.Im = c2.Im;
            return c0;
        }
    }
}
