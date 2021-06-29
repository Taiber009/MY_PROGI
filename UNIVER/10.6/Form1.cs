using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._6
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }
       
        private void Vvod_Click(object sender, EventArgs e)
        {
            char a;
            a = Okno.Text[0];
            Info.Text = Kod.go(a);
        }
    }
}
