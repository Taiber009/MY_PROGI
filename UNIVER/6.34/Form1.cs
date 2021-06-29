using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._34
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
            MessageBox.Show("6.34:");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string go(string s, int x)
        {
            int i, razn, y = s.Length;
            if (x != y)
            {
                if (x > y)
                {
                    while (x > s.Length)
                    {
                        s = "." + s;
                    }
                }
                else
                {
                    string sum = "";
                    razn = y - x;
                    for (i = razn; i < y; i++)
                    {
                        sum += s[i];
                    };
                    s = sum;
                }
            }
            return s;
        }

        private void Okno1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Okno2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vvod_Click_1(object sender, EventArgs e)
        {
            string y = Okno1.Text;
            int z = Convert.ToInt32(Okno2.Text);
            Info.Text = go(y, z);
        }

    }
}
