using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXAMPLE2010
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
            kod = new Kod();
        }
        Kod kod;
        private void B1_Click(object sender, EventArgs e)
        {
            double[] x = new double[] { 
            ParseBox(TB0.Text),
            ParseBox(TB1.Text),
            ParseBox(TB2.Text),
            ParseBox(TB3.Text),
            ParseBox(TB4.Text),
            ParseBox(TB5.Text),
            ParseBox(TB6.Text),
            ParseBox(TB7.Text),
            ParseBox(TB8.Text),
            ParseBox(TB9.Text),
            ParseBox(TB10.Text),
            ParseBox(TB11.Text)
            };

            kod.Solve(ref x);

            TB0.Text = "" + x[0];
            TB1.Text = "" + x[1];
            TB2.Text = "" + x[2];
            TB3.Text = "" + x[3];
            TB4.Text = "" + x[4];
            TB5.Text = "" + x[5];
            TB6.Text = "" + x[6];
            TB7.Text = "" + x[7];
            TB8.Text = "" + x[8];
            TB9.Text = "" + x[9];
            TB10.Text = "" + x[10];
            TB11.Text = "" + x[11];

            if (x[0] > x[1])
                //Lans.Text = "Ограничение по мощности! ("+x[0]+'>'+x[1]+")";
                LAns.Text = "Ограничение по мощности! (" + Compact(x[0]) + " > " + Compact(x[1]) + ")";
            else
                LAns.Text = "Ограничение по полосе! (" + Compact(x[0]) + " < " + Compact(x[1]) + ")";
        }

        private double ParseBox(string s)
        {
            if (s.Length != 0)
                try
                {
                    return Double.Parse(s);
                }
                catch
                {
                    MessageBox.Show("Ты идиот? Зачем написал '" + s + "'?");
                    return 0;
                }
            else
                return 0;
        }

        private string Compact(double d)
        {
            int i = (int)Math.Abs(Math.Log10(d));
            return Math.Round(d / Math.Pow(10, i), 2) + "*10^" + i;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bpre_Click(object sender, EventArgs e)
        {
            LEquals.Text = "= ";
            try
            {
                LEquals.Text = "= " + Math.Round(kod.lin2db(Double.Parse(TBLinVal.Text)), 2) + " dB";
            }
            catch
            {
                MessageBox.Show("Введите число!");
                TBLinVal.Text = "";
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            TB0.Text = "";
            TB1.Text = "";
            TB2.Text = "";
            TB3.Text = "";
            TB4.Text = "";
            TB5.Text = "";
            TB6.Text = "";
            TB7.Text = "";
            TB8.Text = "";
            TB9.Text = "";
            TB10.Text = "";
            TB11.Text = "";
            LAns.Text = "";
            LEquals.Text = "= ";
            TBLinVal.Text = "";
        }
    }
}
