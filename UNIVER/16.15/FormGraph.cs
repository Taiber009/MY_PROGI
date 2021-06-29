using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AllSort
{
    public partial class FormGraph : Form
    {
        Graphics g;
        int I1 = 0, J1 = 0, I2, J2;

        public double x1 = -10, y1 = -100, x2 = Sort.n1000, y2 = Sort.MaxA;

        public FormGraph()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        int II(double x)
        {
            return I1 + (int)((x - x1) * (I2 - I1) / (x2 - x1));
        }

        int JJ(double y)
        {
            return J2 + (int)((y - y1) * (J1 - J2) / (y2 - y1));
        }

        void Draw()
        {
            I2 = ClientRectangle.Width;
            J2 = ClientRectangle.Height;
            y2 = Sort.MaxA;
            y1 = -y2 / 50;
            //const int n = 50;
            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);

            g.DrawLine(Pens.Black,II(x1),JJ(0),II(x2),JJ(0));
            g.DrawLine(Pens.Black, II(0), JJ(y1), II(0), JJ(y2));

            for (int i = 10; i < Sort.n1000; i++)
            {
                g.FillEllipse(Brushes.Black,II(i)-2,JJ(Sort.countA1[i])-2,4,4);
                g.DrawEllipse(Pens.Green, II(i) - 3, JJ(Sort.countB1[i]) - 3, 6, 6);
                g.FillEllipse(Brushes.Red, II(i) - 2, JJ(Sort.countA2[i]) - 2, 4, 4);
                g.DrawEllipse(Pens.Blue, II(i) - 2, JJ(Sort.countB2[i]) - 2, 4, 4);
            }
        }

        private void FormGraph_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }
    }
}
