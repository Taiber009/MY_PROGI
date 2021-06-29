using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _16._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(BoxA.Text),
                   x = Double.Parse(BoxX.Text);
            //int n = Int32.Parse(BoxN.Text);
            Grid.RowCount = 31;
            Grid.ColumnCount = 3;
            //у = a sin(ax) cos2 (x/a)
            Kod.m = new c[30];
            Kod.Go(x, a);
            for (int i = 0; i < 30; i++)
            {
                Grid.Rows[i].Cells[0].Value = a;
                Grid.Rows[i].Cells[1].Value = Kod.m[i].x;
                Grid.Rows[i].Cells[2].Value = Kod.m[i].o;
            }
        }
    }
}
