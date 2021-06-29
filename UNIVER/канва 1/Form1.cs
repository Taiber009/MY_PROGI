using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace канва_1
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        public Form1()
        {
            InitializeComponent();
            canvas = panel1.CreateGraphics();
            kod.bit = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            kod.Draw(e.Graphics);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            kod.grafon(e.X, e.Y,Int32.Parse(Box.Text));
            kod.x1 = e.X;
            kod.y1 = e.Y;
            canvas.DrawImage(kod.bit, ClientRectangle);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            kod.z = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kod.z = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            kod.z = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            kod.z = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            kod.z = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            kod.z1 = 1;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            kod.z1 = 2;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            kod.z1 = 3;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            kod.z1 = 4;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            kod.z1 = 5;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

    }
}
