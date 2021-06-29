using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AllSort
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("ind", "ind");
            dataGridView1.Columns["ind"].Width = 30;
            dataGridView1.Columns.Add("ind1", "A");
            dataGridView1.Columns["ind1"].Width = 50;
            dataGridView1.Columns.Add("ind2", "B");
            dataGridView1.Columns["ind2"].Width = 50;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sort.SetArr();
            int L = Sort.a.Length;
            dataGridView1.RowCount = L;
            for (int i = 0; i <= L - 1; i++)
            {
                dataGridView1[0, i].Value = i;
                dataGridView1[1, i].Value = Sort.a[i];
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Sort.flTools = Convert.ToByte((sender as RadioButton).Tag);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Sort.n - 1; i++)
                Sort.b[i] = Sort.a[i];

            switch (Sort.flTools)
            {
                case 0:
                    Sort.SortBubl();
                    break;
                case 1:
                    Sort.NoRecurs();
                    break;
                case 2:
                    Sort.Recurs(0,Sort.a.Length-1);
                    break;
            }

            int L = Sort.b.Length;
            for (int i = 0; i <= L - 1; i++)
                    dataGridView1[2, i].Value = Sort.b[i];
               
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Sort.Сравнить();
            FormGraph formGraph = new FormGraph();
            formGraph.ShowDialog();
        }


    }
}
