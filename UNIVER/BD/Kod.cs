using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;


namespace BD
{
    public class Kod
    {
        //"Server=127.0.0.1;Port=5439;User Id=postgres;Password=1235;Database=postgres;"
        NpgsqlConnection connect;
        public DataTable[] tables;
        public bool connected;


        public Kod(string c)
        {
            connected = false;
            connect = new NpgsqlConnection(c);
            if (TestRequest())
            {
                connected = true;
                tables = new DataTable[5];
                tables[0] = new DataTable("PHONE");
                tables[1] = new DataTable("TELEPHONE_SUBSCRIBER");
                tables[2] = new DataTable("HOUSE_OWNER");
                tables[3] = new DataTable("STREET");
                tables[4] = new DataTable("CITY");
                try
                {
                    UpdateAll();
                }
                catch
                {

                }
            }
        }
        /*public Kod(string c, DataGridView[] dg)
        {
            connected = false;
            connect = new NpgsqlConnection(c);
            command = null;
            if (TestRequest())
            {
                connected = true;
                tables = new DataTable[5];
                tablesName[0] = "PHONE";
                tablesName[1] = "TELEPHONE_SUBSCRIBER";
                tablesName[2] = "HOUSE_OWNER";
                tablesName[3] = "STREET";
                tablesName[4] = "CITY";
                try
                {
                    UpdateAll();
                    /*for (int i = 0; i < dg.Length; i++)
                    {
                        dg[i].DataSource = Request2("SELECT * FROM " + tablesName[i] + ";");
                    }
                }
                catch
                {

                }
            }
        }*/
        public bool TestRequest()
        {
            try
            {
                RequestWithoutReturn("select man_id from telephone_subscriber");
                return true;
            }
            catch
            {
                return false;
            }
        }
        /*public DataTable RequestNew(string command)
        {
            try
            {
                DataTable datatable = new DataTable();
                connect.Open();
                adapter = new NpgsqlDataAdapter(command, connect);
                //NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(adapter);
                // cb.QuoteIdentifier(
                adapter.Fill(datatable);
                //cb.GetUpdateCommand();
                //adapter.Update(datatable);
                connect.Close();
                return datatable;
            }
            catch //(Exception ex)
            {
                connect.Close();
                //List<string[]> err = new List<string[]>();
                //err.Add(new string[] { ex.Message });
                return null;
            }
        }*/
        public DataTable Request(string command, ref DataTable dt)
        {
            try
            {
                dt = new DataTable(dt.TableName);
                connect.Open();
                new NpgsqlDataAdapter(command, connect).Fill(dt);
                connect.Close();
                return dt;
            }
            catch //(Exception ex)
            {
                connect.Close();
                return null;
            }
        }
        public DataTable Request(string s, string[] pars)
        {
            DataTable datatable = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand(s, connect);
            for (int i = 0; i < pars.Length; i++)
            {
                command.Parameters.AddWithValue("@" + i, pars[i]);///////////////////////
            }
            try
            {
                connect.Open();
                new NpgsqlDataAdapter(command).Fill(datatable);
                connect.Close();//////////////////////
                return datatable;
            }
            catch
            {
                connect.Close();
                return null;
            }
        }
        
        public void RequestWithoutReturn(string command)
        {
            try
            {
                connect.Open();
                new NpgsqlCommand(command, connect).ExecuteNonQuery();
            }
            finally
            {
                connect.Close();
            }
        }
        private void Fixdate(List<string[]> l, int i)
        {
            foreach (string[] s in l)
            {
                s[i] = s[i].Split(' ')[0];
            }
        }
        public void Update(int i)
        {
            try
            {
                tables[i] = Request("SELECT * FROM " + tables[i].TableName + ";", ref tables[i]);
            }
            catch
            {

            }
        }
        public void UpdateAll()
        {
            try
            {
                for (int i = 0; i < tables.Length; i++)
                    Update(i);
            }
            catch
            {

            }
        }
        public string[] TableFieldsName(int n)
        {
            string[] sa = new string[tables[n].Columns.Count];
            for (int i = 0; i < tables[n].Columns.Count; i++)
            {
                sa[i] = tables[n].Columns[i].ColumnName;
            }
            return sa;
        }
        public string TableFieldsName(DataTable dt)
        {
            string s = dt.Columns[0].ColumnName;
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                s += ','+dt.Columns[i].ColumnName;
            }
            return s;
        }
        public string[] TableFieldsNameWithoutAutoincrement(int n)
        {
            string[] sa = new string[0];
            for (int i = 0; i < tables[n].Columns.Count; i++)
            {
                if (!((n == 1 || n == 3 || n == 4) && i == 0))
                {
                    Array.Resize(ref sa, sa.Length + 1);
                    sa[sa.Length - 1] = tables[n].Columns[i].ColumnName;
                }
            }
            return sa;
        }
    }
}

