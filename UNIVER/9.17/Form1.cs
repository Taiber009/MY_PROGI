using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._17
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }
        public int go1(int n, int[,] a)
        {
            int i, j, min = 0, max = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        min = a[j, i];
                    }
                    else
                    {
                        if (a[j, i] < min)
                        {
                            min = a[j, i];
                        }
                    }
                }
                if (i == 0)
                {
                    max = min;
                }
                else
                {
                    if (max < min)
                    {
                        max = min;
                    }
                }
            }
            return max;
        }
        public string go2(int n, int[,] a)
        {
            string win = "d";
            int i, j, up = 0, down = 0;
            for (j = 0; j < n; j++)
            {
                for (i = 0; i < n; i++)
                {
                    if ((i > j) && (a[j, i] % 2 == 0))
                    {
                        up++;
                    }
                    if ((j > i) && (a[j, i] % 2 == 0))
                    {
                        down++;
                    }
                }
            }
            if (up > down)
            {
                win = "Выше";
            }
            if (up < down)
            {
                win = "Ниже";
            }
            if (up == down)
            {
                win = "Ничья";
            }
            return win;

        }
        private void Vvod_Click(object sender, EventArgs e)
        {
            int i, j, n = Int32.Parse(Okno1.Text);
            int[,] a = new int[n, n];
            Random rnd = new Random();
            Okno2.Clear();
            for (j = 0; j < n; j++)
            {
                for (i = 0; i < n; i++)
                {
                    a[j, i] = rnd.Next(10, 100);
                    Okno2.Text += a[j, i] + "  ";
                }
                Okno2.Text += Environment.NewLine;
            }
            Info3.Text = "Ответ: ";
            if (Check1.Checked == true)
            {
                Info3.Text += go1(n, a);
            }
            if (Check2.Checked == true)
            {
                Info3.Text += go2(n, a);
            }
        }
    }
}


