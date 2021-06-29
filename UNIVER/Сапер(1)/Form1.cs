using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Сапер_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kod Exmpl;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Newgame();
        }
        private void Newgame()
        {
            int a;
            if (!Int32.TryParse(Box.Text, out a))
                a = 9;
            Grid.RowCount = a;
            Grid.ColumnCount = a;
            for (int i = 0; i < a; i++)
            {
                Grid.Columns[i].Width = 20;
                Grid.Rows[i].Height = 20;
            }
            Grid.Width = a * 20 + 3;
            Grid.Height = a * 20 + 3;
            Form1.ActiveForm.Width = a * 20 + 100;
            Form1.ActiveForm.Height = a * 20 + 50;
            Exmpl = new Kod(a);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (Cheat.Checked == true)
                        Grid.Rows[i].Cells[j].Value = Exmpl.PoleGet(j + 1, i + 1);
                    else
                        Grid.Rows[i].Cells[j].Value = null;
                }
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (Exmpl.PoleGet(x + 1, y + 1) != 0)
                if (Exmpl.PoleGet(x + 1, y + 1) != 10)
                    Grid.Rows[y].Cells[x].Value = Exmpl.PoleGet(x + 1, y + 1);
                else
                {
                    Exmpl.RecursStart(x, y);
                    for (int k = Exmpl.CoordsNubmers; k > 0; k--)
                    {
                        int[] z = Exmpl.MyStack.Pop();
                        Grid.Rows[z[1]].Cells[z[0]].Value = Exmpl.PoleGet(z[0] + 1, z[1] + 1);
                    }
                }
            else
            {
                {
                    for (int i = 0; i < Exmpl.Lenght(); i++)
                    {
                        for (int j = 0; j < Exmpl.Lenght(); j++)
                        {
                            if (Exmpl.PoleGet(j + 1, i + 1) == 0)
                                Grid.Rows[i].Cells[j].Value = Exmpl.PoleGet(j + 1, i + 1);
                        }
                    }
                }
                MessageBox.Show("Lose");
                Newgame();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < Exmpl.Lenght(); i++)
            {
                for (int j = 0; j < Exmpl.Lenght(); j++)
                {
                    if (Cheat.Checked == true)
                    {
                        if ((Grid.Rows[i].Cells[j].Value) != null)
                            Exmpl.PoleSafe[j, i] = (int)(Grid.Rows[i].Cells[j].Value);
                        else
                            Exmpl.PoleSafe[j, i] = -1;
                        Grid.Rows[i].Cells[j].Value = Exmpl.PoleGet(j + 1, i + 1);
                    }
                    else
                        if (Exmpl.PoleSafe[j, i] != -1)
                            Grid.Rows[i].Cells[j].Value = Exmpl.PoleSafe[j, i];
                        else
                            Grid.Rows[i].Cells[j].Value = null;
                }
            }
        }
    }
}

