using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace _15._44
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }

        private void Vvod_Click(object sender, EventArgs e)
        {
            Okno1.Clear();
            Okno2.Clear();

            Okno1.Text = Kod.read();
            Okno2.Text = Kod.print();
        }  
    }
}
