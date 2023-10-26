using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BD
{
    public partial class Adder : Form
    {
        internal Kod mycon;
        int n;
        string[] columnsname;
        public Adder(Kod m, int t)
        {
            InitializeComponent();
            mycon = m;
            n = t;
            columnsname = mycon.TableFieldsNameWithoutAutoincrement(t);
            Gadd.RowCount = 1;
            Gadd.ColumnCount = columnsname.Length;
            for (int i = 0; i < columnsname.Length; i++)
                Gadd.Columns[i].HeaderText = columnsname[i];
        }

        private void Badd_Click(object sender, EventArgs e)
        {////ПОФИКСИТЬ ВВОД КЛЮЧЕЙ
            try
            {
                string s1 = ArrayToString(columnsname), s2 = Params();
                mycon.Request("Insert into " + mycon.tables[n].TableName + "(" + s1 + ") values(" + s2 + ");",RowToArray());
                Linfo.Text = "В таблицу " + mycon.tables[n].TableName + " добавлена новая запись (" + RowToString() + ")!";
                for (int i = 0; i < Gadd.ColumnCount; i++)
                    Gadd.Rows[0].Cells[i].Value = null;//очистка
            }
            catch (Exception ex)
            {
                Linfo.Text = ex.Message;
            }
        }

        private string ArrayToString(string[] arr)
        {
            string s = arr[0];
            for (int i = 1; i < columnsname.Length; i++)
                s += "," + columnsname[i];
            return s;
        }
        private string[] RowToArray()
        {
            string[] s = new string[Gadd.ColumnCount];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Gadd.Rows[0].Cells[i].Value.ToString();
            }
            return s;
            /*string s = '\u0027' + Gadd.Rows[0].Cells[0].Value.ToString() + '\u0027';
            for (int i = 1; i < Gadd.ColumnCount; i++)
                if (Gadd.Rows[0].Cells[i].Value != null)
                    s += ",'" + Gadd.Rows[0].Cells[i].Value.ToString() + '\u0027';
                else
                    s += ",''";
            return s;*/
        }
        private string Params()
        {
            string s ="@0";
            for (int i = 1; i < Gadd.ColumnCount; i++)
            {
                s += ",@"+i;
            }
            return s;
        }
        private string RowToString()
        {
            string s = Gadd.Rows[0].Cells[0].Value.ToString();
            for (int i = 1; i < Gadd.ColumnCount; i++)
                s += "," + Gadd.Rows[0].Cells[i].Value.ToString();
            return s;
        }
    }
}
