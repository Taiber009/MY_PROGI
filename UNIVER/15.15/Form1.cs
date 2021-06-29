using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _15._15
{
    public partial class Proga1 : Form
    {
        public Proga1()
        {
            InitializeComponent();
        }

        private void Vvod_Click(object sender, EventArgs e)
        {
            string s;
            Queue<string> och = new Queue<string>();
            //
            StreamReader file = 
                new StreamReader(@"F:\Text.txt", Encoding.GetEncoding("windows-1251"));
            while ((s = file.ReadLine()) != null)
                och.Enqueue(s);
            //
            Okno2.Clear();
            Okno3.Clear();
            Okno2.Visible = Okno3.Visible = Info2.Visible = Info3.Visible = true;
            foreach (string x in och)
                Okno2.Text += x + Environment.NewLine;
            och = Kod2.go(och, Okno1.Text);
            foreach (string x in och)
                Okno3.Text += x + Environment.NewLine;
            
        }
    }
}
