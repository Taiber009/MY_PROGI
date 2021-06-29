using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace TestColors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.OpenFile() != null)
                {
                    Bitmap bit = (Bitmap)Image.FromFile(ofd.FileName);
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb1.Image = bit;
                    decimal a = 0, r = 0, g = 0, b = 0;
                    Color color = Color.Black;
                    for (int i = 0; i < bit.Width; i++)
                    {
                        for (int j = 0; j < bit.Height; j++)
                        {
                            color = bit.GetPixel(i, j);
                            a += color.A;
                            r += color.R;
                            g += color.G;
                            b += color.B;
                        }
                    }
                    decimal countPix = bit.Width * bit.Height;
                    color = Color.FromArgb((int)Math.Round(a / countPix),
                        (int)Math.Round(r / countPix),
                        (int)Math.Round(g / countPix),
                        (int)Math.Round(b / countPix));
                    pb2.BackColor = color;
                    tb1.Text = color.ToString();
                }
            }
        }
    }
}
