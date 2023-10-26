using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BD
{
    public partial class DebugOnly : Form
    {
        public DebugOnly(Kod m)
        {
            InitializeComponent();
            mycon = m;
        }
        internal Kod mycon;

        
        private void Brequest_Click(object sender, EventArgs e)
        {
            TBinfo.Text = "";

            if (mycon == null)
                TBinfo.Text = "Не установлено соединение!";
            else
            {
                DataTable dt = new DataTable("Debug");
                Grid.DataSource=mycon.Request(TBrequest.Text,ref dt);
            }
        }
        private void GridFill(DataGridView g, List<string[]> l)
        {
            g.Rows.Clear();
            g.Columns.Clear();

            if (l != null)
            {
                if (l.Count > 1)
                {
                    string[] row = l[0];
                    g.RowCount = l.Count - 1;
                    g.ColumnCount = row.Length;

                    for (int j = 0; j < row.Length; j++)
                    {
                        g.Columns[j].Name = row[j];
                        g.Columns[j].HeaderText = row[j];
                    }
                    for (int i = 0; i < l.Count - 1; i++)
                    {
                        row = l[i + 1];
                        for (int j = 0; j < row.Length; j++)
                            g.Rows[i].Cells[j].Value = row[j];
                    }
                    TBinfo.Text += "Запрос выполнен" + Environment.NewLine;
                }
                else
                {
                    TBinfo.Text += l[0][0] + Environment.NewLine;
                }
            }
            else
            {
                TBinfo.Text += "Запрос выполнен (без ответа)" + Environment.NewLine;
            }
            //Grid =mycon.Request(TBrequest.Text);
        }
    }
}
