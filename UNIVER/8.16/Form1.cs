using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8._16
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }
        public int[,] go1(int M, ref int[,] a)
        {
            int i, j;
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < M; i++)
                {
                    if (j > i)
                    {
                        a[j, i] = 0;
                    }
                }
            }
            return a;
        }
        public int[,] go2(int M, ref int[,] a)
        {
            int i, j;
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < M; i++)
                {
                    if (j < i)
                    {
                        a[j, i] = 0;
                    }
                }
            }
            return a;
        }
        public int[,] go3(int M, ref int[,] a)
        {
            int i, j;
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < M; i++)
                {
                    if (j > M - i - 1)
                    {
                        a[j, i] = 0;
                    }
                }
            }
            return a;
        }
        public int[,] go4(int M, ref int[,] a)
        {
            int i, j;
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < M; i++)
                {
                    if (j < M - i - 1)
                    {
                        a[j, i] = 0;
                    }
                }
            }
            return a;
        }

        private void Vvod_Click_1(object sender, EventArgs e)
        {
            int i, j, M = Int32.Parse(Okno1.Text);
            Tab1.RowCount = M;
            Tab1.ColumnCount = M;
            int[,] a = new int[M, M];
            for (j = 0; j < M; j++)
            {
                Tab1.Columns[j].Width = 20;
                for (i = 0; i < M; i++)
                {
                    a[j, i] = 1;
                }
            }
            if (Check1.Checked == true)
            {
                go1(M, ref a);
            }
            if (Check2.Checked == true)
            {
                go2(M, ref a);
            }
            if (Check3.Checked == true)
            {
                go3(M, ref a);
            }
            if (Check4.Checked == true)
            {
                go4(M, ref a);
            }
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < M; i++)
                {
                    Tab1.Rows[j].Cells[i].Value = a[j, i];
                    //Tab1.Rows[j].Cells[i].Style.BackColor = (a[j,i] == 0) ? Color.Red : Color.Blue;
                }
                Tab1.Columns[j].Width = 20;
            }
        }
    }
}
