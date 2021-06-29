using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._6
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }

        private void Vvod_Click(object sender, EventArgs e)
        {
            Info4.Text = "Ответ: ";
            int d = Convert.ToInt32(Okno1.Text), m = Convert.ToInt32(Okno2.Text), y = Convert.ToInt32(Okno3.Text);
            if ((y<=2000)&&(((d <= 31) && ((m == 1) || (m == 3) || (m == 5) || (m == 7) || (m == 8) || (m == 10) || (m == 12))) || ((d <= 30) && ((m == 4) || (m == 6) || (m == 9) || (m == 11))) || ((y % 4 == 0) && (d <= 29)) || (d <= 28)))
            {
                Info4.Text += Kod.go(d, m, y);
            }
            else
            {
                Info4.Text += "Ошибка!";
            }
        }
    }
}
