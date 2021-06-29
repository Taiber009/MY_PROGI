using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1task
{
    public partial class Proga : Form
    {
        string s;
        public Proga()
        {
            InitializeComponent();
        }


        private void Click_Click(object sender, EventArgs e)
        {
            string[] s = new string[StringsAlpha.RowCount - 1];
            for (int i = 0; i < StringsAlpha.RowCount - 1; i++)
            {
                if (StringsAlpha.Rows[i].Cells[0].Value != null)  //проверка на пустоту
                {
                    s[i] = Convert.ToString(StringsAlpha.Rows[i].Cells[0].Value);
                }
                else //если пусто, то уменьшение длинны массива s на 1;
                {
                    Array.Resize(ref s, s.Length - 1);
                }
            }
            Alpha.BackAlphabet(ref s);
            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length-1)
                {
                    StringsBeta.Rows.Add(1);
                }
                StringsBeta.Rows[i].Cells[0].Value = s[i];
            }
        }
    }
}
