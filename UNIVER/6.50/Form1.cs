using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6._50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("50.Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). Вывести строку, содержащую эти же слова (разделенные одним пробелом), но расположенные в алфавитном порядке.");
        }
        public string go(string s)
        {
            int i, j;
            bool proverka = true;
            string left = "", middle = "", right = "";
            for (i = 0; i < s.Length; i++)
            {
                if ((s[i] == ' ') && (s[i + 1] != ' '))
                {
                    middle = left + middle + right;
                    left = "";
                    right = "";
                    for (j = 0; j < middle.Length; j++)
                    {
                        if ((proverka == true) && ((middle[j] == ' ') && (s[i + 1] < middle[j + 1]) || (s[i + 1] < middle[0])))
                        {
                            right += " ";
                            proverka = false;
                        }
                        if (proverka == true)
                        {
                            left += middle[j];
                        }
                        else
                        {
                            if ((middle[j] != ' ') || (middle[j] != middle.Length))
                            {
                                right += middle[j];
                            }
                        }
                    }
                    if (left != "")
                    {
                        left += " ";
                    }
                    proverka = true;
                    middle = "";
                }
                if (s[i] != ' ')
                {
                    middle += s[i];
                }
            }
            left = left + middle + right;
            middle = "";
            middle += left[0];
            for (i = 1; i < left.Length; i++)
            {
                if (((left[i] != ' ') || (left[i - 1] != ' ')) && ((i != left.Length) || (left[i] != ' ')))
                {
                    middle += left[i];
                }
            }
            return(middle);
        }
        private void Vvod_Click(object sender, EventArgs e)
        {
            string y = Okno1.Text;
            Info3.Text = go(y);
        }

    }
}
