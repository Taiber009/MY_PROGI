using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8._32
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }

        private void Vvod_Click(object sender, EventArgs e)
        {
            int i, j, N = Int32.Parse(Okno1.Text), M = Int32.Parse(Okno2.Text);
            int[,] a = new int[M, N];
            Random rnd = new Random();
            Tab1.ColumnCount = Tab2.ColumnCount = N;
            Tab1.RowCount = Tab2.RowCount = M;
            Tab1.RowTemplate.Height = Tab2.RowTemplate.Height = 20;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    a[j, i] = rnd.Next(10, 100);
                    Tab1.Rows[j].Cells[i].Value = a[j, i];
                }
                Tab1.Columns[i].Width = Tab2.Columns[i].Width = 20;
            }
            if (Check1.Checked == true)
            {
                a = go1(M, N, a);
            }
            if (Check2.Checked == true)
            {
                a = go2(M, N, a);
            }
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < N; i++)
                {
                    Tab2.Rows[j].Cells[i].Value = a[j, i];
                }
            }
        }
        /*public bool[,] getNeighbours(int x, int y, out int nx, out int ny)
        {
            bool[,] ans = new bool[3,3];
            //.ans[i,j] = (i+x-1 > 0) && 
            return ans;
        }*/
        public int[,] go1(int M, int N, int[,] a)
        {
            int i, j, i2, j2;
            int[,] b = new int[M, N];
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < N; i++)
                {
                    b[j, i] = 0;
                    for (j2 = (j - 1); j2 <= (j + 1); j2++)
                    {
                        for (i2 = (i - 1); i2 <= (i + 1); i2++)
                        {
                            if ((j2>=0)&&(j2<=M)&&(i2>=0)&&(i2<=N)&&((j2!=j)&&(i2!=i)))
                            {
                                if (a[j, i] >= a[j2, i2])
                                {
                                    b[j, i] = a[j, i];
                                }
                            }
                        }
                    }
                }
            }
            return b;
        }
        public int[,] go2(int M, int N, int[,] a)
        {
            int i, j;
            int[,] b = new int[M, N];
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < N; i++)
                {
                    if (j == 0)
                    {
                        if (i == 0)
                        {
                            if ((a[j, i] > a[j + 1, i]) && (a[j, i] > a[j, i + 1]) && (a[j, i] > a[j + 1, i + 1]))
                            {
                                b[j, i] = 0;
                            }
                            else
                            {
                                b[j, i] = a[j, i];
                            }
                        }
                        if (i == N - 1)
                        {
                            if ((a[j, i] > a[j + 1, i]) && (a[j, i] > a[j, i - 1]) && (a[j, i] > a[j + 1, i - 1]))
                            {
                                b[j, i] = 0;
                            }
                            else
                            {
                                b[j, i] = a[j, i];
                            }
                        }
                        if ((i != 0) && (i != N - 1))
                        {
                            if ((a[j, i] > a[j + 1, i]) && (a[j, i] > a[j, i - 1]) && (a[j, i] > a[j, i + 1]) && (a[j, i] > a[j + 1, i + 1]) && (a[j, i] > a[j + 1, i - 1]))
                            {
                                b[j, i] = 0;
                            }
                            else
                            {
                                b[j, i] = a[j, i];
                            }
                        }
                    }
                    if (j == M - 1)
                    {
                        if (i == 0)
                        {
                            if ((a[j, i] > a[j - 1, i]) && (a[j, i] > a[j, i + 1]) && (a[j, i] > a[j - 1, i + 1]))
                            {
                                b[j, i] = 0;
                            }
                            else
                            {
                                b[j, i] = a[j, i];
                            }
                        }
                        if (i == N - 1)
                        {
                            if ((a[j, i] > a[j - 1, i]) && (a[j, i] > a[j, i - 1]) && (a[j, i] > a[j - 1, i - 1]))
                            {
                                b[j, i] = 0;
                            }
                            else
                            {
                                b[j, i] = a[j, i];
                            }
                        }
                        if ((i != 0) && (i != N - 1))
                        {
                            if ((a[j, i] > a[j - 1, i]) && (a[j, i] > a[j, i - 1]) && (a[j, i] > a[j, i + 1]) && (a[j, i] > a[j - 1, i + 1]) && (a[j, i] > a[j - 1, i - 1]))
                            {
                                b[j, i] = 0;
                            }
                            else
                            {
                                b[j, i] = a[j, i];
                            }
                        }
                    }
                    if ((i == 0) && (j != 0) && (j != M - 1))
                    {
                        if ((a[j, i] > a[j + 1, i]) && (a[j, i] > a[j - 1, i]) && (a[j, i] > a[j, i + 1]) && (a[j, i] > a[j - 1, i + 1]) && (a[j, i] > a[j + 1, i + 1]))
                        {
                            b[j, i] = 0;
                        }
                        else
                        {
                            b[j, i] = a[j, i];
                        }
                    }
                    if ((i == N - 1) && (j != 0) && (j != M - 1))
                    {
                        if ((a[j, i] > a[j + 1, i]) && (a[j, i] > a[j - 1, i]) && (a[j, i] > a[j, i - 1]) && (a[j, i] > a[j - 1, i - 1]) && (a[j, i] > a[j + 1, i - 1]))
                        {
                            b[j, i] = 0;
                        }
                        else
                        {
                            b[j, i] = a[j, i];
                        }
                    }
                    if ((i != 0) && (i != N - 1) && (j != 0) && (j != M - 1))
                    {
                        if ((a[j, i] > a[j + 1, i]) && (a[j, i] > a[j - 1, i]) && (a[j, i] > a[j, i + 1]) && (a[j, i] > a[j, i - 1]) && (a[j, i] > a[j - 1, i - 1]) && (a[j, i] > a[j + 1, i - 1]) && (a[j, i] > a[j - 1, i + 1]) && (a[j, i] > a[j + 1, i + 1]))
                        {
                            b[j, i] = 0;
                        }
                        else
                        {
                            b[j, i] = a[j, i];
                        }
                    }
                }
            }
            return b;
        }
    }
}
