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
    public partial class Finder : Form
    {
        internal Kod mycon;
        DataTable table;
        public Finder(Kod k, int t, string s)
        {
            mycon = k;
            table = mycon.tables[t];
            InitializeComponent();
            Linfo.Text = "Поиск в таблице " + s;
            //for (int i = 0; i < table.Columns.Count; i++)
            //    Grid.Columns.Add(table.Columns[i].ColumnName.ToString(), table.Columns[i].ColumnName.ToString());
        }

        private void Bfind_Click(object sender, EventArgs e)
        {
            TBinfo.Text = "";
            //if (Grid.Rows.Count != 0)
            //    Grid.Rows.Clear();
            Grid.DataSource = null;
            if (TBrequest.Text.Length != 0)
            {
                if (mycon != null)
                {
                    string[] tags = TBrequest.Text.Split(' ');
                    for (int i = 0; i < tags.Length; i++)
                        tags[i] = '%' + tags[i] + '%';
                    string tablefieldsname = mycon.TableFieldsName(table);
                    string command = "Select * from " + table.TableName + " where concat(" + tablefieldsname + ") like @0";
                    for (int i = 1; i < tags.Length; i++)
                    {
                        command += " and concat(" + tablefieldsname + ") like @" + i;
                    }
                    command += ";";
                    DataTable dt = mycon.Request(command, tags);
                    Grid.DataSource = dt;
                    /*bool[] existence = new bool[tags.Length];
                    for (int i = 0; i < table.Rows.Count; i++)//идем по строкам
                    {
                        for (int t = 0; t < tags.Length; t++)
                            existence[t] = false;
                        for (int j = 0; j < table.Columns.Count; j++)//идем по ячейкам строки
                        {
                            for (int t = 0; t < tags.Length; t++)//сравниваем строку с искомыми словами
                            {
                                if (table.Rows[i].ItemArray[j].ToString().Contains(tags[t]) && existence[t] == false)/////////
                                {
                                    existence[t] = true;
                                    break;
                                }
                            }
                        }
                        if (Allexist(existence))
                            Grid.Rows.Add(table.Rows[i].ItemArray);
                    }*/
                    if (Grid.Rows.Count == 0)
                        TBinfo.Text = "По запросу '" + TBrequest.Text + "' ничего не найдено!";
                }
                else
                    TBinfo.Text = "Не установлено соединение!";
            }
        }
        private bool Allexist(bool[] b)
        {
            for (int i = 0; i < b.Length; i++)
                if (!b[i])
                    return false;
            return true;
        }
    }
}
