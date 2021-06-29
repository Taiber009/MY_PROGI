using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._18
{
    public partial class PROGA : Form
    {
        public PROGA()
        {
            InitializeComponent();
            MessageBox.Show("6.18: Дана строка. Определить, стоят ли в данной строке подряд символы 'а' и 'б'.");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string doSomething(string s)
        {
            string win = "False";
            int i;
            for (i = 0; i < s.Length - 1; i++)
            {
                if ((s.Substring(i, 2) == "аб") || (s.Substring(i, 2) == "ба"))
                {
                    win = "True";
                }
            }
            return win;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = OKNO.Text;
            MessageBox.Show(doSomething(s));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
