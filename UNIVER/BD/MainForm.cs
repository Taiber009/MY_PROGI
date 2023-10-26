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
    public partial class MainForm : Form
    {
        Kod mycon;
        DataGridView[] gridtables;
        ListSortDirection direction;
        public Form form;
        public MainForm()
        {
            InitializeComponent();
            //Grid.AutoGenerateColumns = false;
            gridtables = new DataGridView[] { GridPhone, GridSub, GridHouse, GridStreet, GridCity };
        }
        private void GridUpdate(int i)
        {
            mycon.Update(i);
            gridtables[i].DataSource = mycon.tables[i];
        }
        private void GridUpdateAll()
        {
            mycon.UpdateAll();
            GridConnectAll();
        }
        private void GridConnectAll()
        {
            for (int i = 0; i < gridtables.Length; i++)
            {
                gridtables[i].DataSource = mycon.tables[i];
            }
        }

        private void SwitchSortDirection()
        {
            if (direction == ListSortDirection.Ascending)
            {
                direction = ListSortDirection.Descending;
                Ldirection.Text = "по убыванию";
            }
            else
            {
                direction = ListSortDirection.Ascending;
                Ldirection.Text = "по возрастанию";
            }
        }







        private void Const_Click(object sender, EventArgs e)
        {
            //TBconnect.Text = "Server=127.0.0.1;Port=5439;User Id=postgres;Password=1235;Database=local;";
            TBserver.Text = "127.0.0.1";
            TBport.Text = "5439";
            TBuser.Text = "postgres";
            TBpass.Text = "1235";
            TBdatabase.Text = "postgres";
        }

        private void Bconnect_Click(object sender, EventArgs e)
        {
            string s = "Server=" + TBserver.Text +
                ";Port=" + TBport.Text +
                ";User Id=" + TBuser.Text +
                ";Password=" + TBpass.Text +
                ";Database=" + TBdatabase.Text + ';';
            try
            {
                mycon = new Kod(s);
            }
            catch (Exception ex)
            {
                TBinfo.Text = ex.Message;
            }
            if (mycon.connected)
            {
                TBinfo.Text = "Соединение установлено на " + s + Environment.NewLine;
                GridConnectAll();

                if (CBtables.Items.Count == 0)
                {
                    CBtables.Items.Add("Phone");
                    CBtables.Items.Add("Telephone_subscriber");
                    CBtables.Items.Add("House_owner");
                    CBtables.Items.Add("Street");
                    CBtables.Items.Add("City");
                }
            }
            else
            {
                TBinfo.Text = "Соединение не установлено!";
            }
        }


        private void Bupdate_Click(object sender, EventArgs e)
        {
            /* for (int i = 0; i < gridtables.Length; i++)
                 if (IsItChange(gridtables[i], mycon.tables[i]))
                     GridFill(gridtables[i], mycon.tables[i]);*/
        }

        private void Bdebug_Click(object sender, EventArgs e)
        {
            form = new DebugOnly(mycon);
            form.ShowDialog();
        }

        private void Breject_Click(object sender, EventArgs e)
        {
            GridUpdateAll();
            TBinfo.Text = "Данные всех таблиц обновлены";
        }

        private void Bdelete_Click(object sender, EventArgs e)
        {

            if (CBtables.SelectedItem != null)
            {
                int index = CBtables.SelectedIndex;
                string command = "Delete from " + mycon.tables[index].TableName + " where " + gridtables[index].Columns[0].HeaderText + "=@0";
                string[] pars;
                if (index != 2)
                {
                    command += ";";
                    pars = new string[] { gridtables[index].CurrentRow.Cells[0].Value.ToString() };
                }
                else
                {
                    command += " and " + gridtables[index].Columns[1].HeaderText + "=@1;";
                    pars = new string[]{gridtables[index].CurrentRow.Cells[0].Value.ToString(),
                                      gridtables[index].CurrentRow.Cells[1].Value.ToString()};
                }
                try
                {
                    mycon.Request(command, pars);
                    GridUpdate(index);
                    TBinfo.Text = "Строка в таблице " + '"' + mycon.tables[index].TableName + '"' + " была удалена!";
                }
                catch (Exception ex)
                {
                    TBinfo.Text = ex.Message;
                }
            }
            else
                TBinfo.Text = "ОШИБКА: Выберите таблицу!";
        }

        private void Bfind_Click(object sender, EventArgs e)
        {
            if (CBtables.SelectedItem != null)
            {
                form = new Finder(mycon, CBtables.SelectedIndex, CBtables.SelectedItem.ToString());
                form.Show();
                TBinfo.Text = "";
            }
            else
                TBinfo.Text = "ОШИБКА: Выберите таблицу!";
        }

        private void Bnew_Click(object sender, EventArgs e)
        {
            if (CBtables.SelectedItem != null)
            {
                int index = CBtables.SelectedIndex;
                form = new Adder(mycon, index);
                form.ShowDialog();
                try
                {
                    mycon.Update(index);
                }
                catch (Exception ex)
                {
                    TBinfo.Text = ex.Message;
                }
                GridUpdate(index);
                TBinfo.Text = "";
            }
            else
                TBinfo.Text = "ОШИБКА: Выберите таблицу!";

        }

        private void CBtables_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBsort.DataSource = null;
            CBsort.Items.Clear();
            CBsort.DataSource = mycon.TableFieldsName(CBtables.SelectedIndex);
        }

        private void CBsort_SelectedIndexChanged(object sender, EventArgs e)
        {
            direction = ListSortDirection.Descending;
        }

        private void Bsort_Click(object sender, EventArgs e)
        {
            if (CBsort.SelectedItem != null)
            {
                SwitchSortDirection();
                gridtables[CBtables.SelectedIndex].Sort(gridtables[CBtables.SelectedIndex].Columns[CBsort.SelectedIndex], direction);
                TBinfo.Text = "Таблица " + CBtables.SelectedItem + " отсортирована по столбцу " + CBsort.SelectedItem + " " + Ldirection.Text;
            }
            else
                TBinfo.Text = "ОШИБКА: Выберите таблицу и столбец для сортировки!";
        }
    }
}
