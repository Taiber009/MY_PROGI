using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9._17_9._32
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }

        private void Vvod_Click(object sender, EventArgs e)
        {
            int i, j, n = Int32.Parse(Okno1.Text);
            int[,] a = new int[n, n];
            Random rnd = new Random();
            Tab1.ColumnCount = n;
            Tab1.RowCount=n;
            Tab1.RowTemplate.Height = 20;
            for (j = 0; j < n; j++)
            {
                for (i = 0; i < n; i++)
                {
                    a[j, i] = rnd.Next(10, 100);
                    Tab1.Rows[j].Cells[i].Value=a[j,i];
                }
                Tab1.Columns[j].Width = 20;
            }
            Info3.Text = "Ответ: ";
            if (Check1.Checked == true)
            {
                Info3.Text += go1(n, a);
            }
            if (Check2.Checked == true)
            {
                i = go2(n, a);
                if (i>0)
                {
                    Info3.Text +=("выше больше на "+i+" элементов");
                }
                if (i < 0)
                {
                    Info3.Text += ("ниже больше на " + Math.Abs(i) + " элементов");
                }
                if (i == 0)
                {
                    Info3.Text += ("ничья");
                }
            }
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
        public int go2(int n, int[,] a)
        {
            int win, i, j, up = 0, down = 0;
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
            win = up - down;
            return win;
        }
    }
}
