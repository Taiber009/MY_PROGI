using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._16
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }

        public string go(int k, int n, string s)
        {
            int i, j=0,Max=0;
            int[] a = new int[k * n];
            string win = "", y = "";
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    y += s[i];
                }
                else
                {
                    a[j] = Int32.Parse(y);
                    j++;
                    y = "";
                }
            }
            a[j] = Int32.Parse(y);
            for (j = 0; j < n; j++)
            {
                for (i = 0; i < k; i++)
                {
                    if (i == 0)
                    {
                        Max = a[i + j * k];
                    }
                    if (Max < a[i + j * k])
                    {
                        Max = a[i + j * k];
                    }

                }
                win += Max + " ";
            }
            return win;
        }
        
        private void Vvod_Click(object sender, EventArgs e)
        {
            int n, k;
            if (Okno3.Visible==true)
            {
                k = Int32.Parse(Secret1.Text);
                n = Int32.Parse(Secret2.Text);
                Okno4.Text=go(k,n,Okno3.Text);
                Okno3.Enabled = false;
                Info4.Visible = Okno4.Visible = true;
            }
            if (Okno1.Visible==true)
            {
                k = Int32.Parse(Okno1.Text);
                n = Int32.Parse(Okno2.Text);
                Secret1.Text = System.String.Format("{0}", k);
                Secret2.Text = System.String.Format("{0}", n);
                Info3.Text = "Введите "+n*k+" чисел через пробел:";
                Info1.Visible = Info2.Visible = Okno1.Visible = Okno2.Visible = false;
                Info3.Visible = Okno3.Visible = true;
            }
        }
      
    }
}
