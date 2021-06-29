using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace InfBez6
{
    public partial class F : Form
    {
        Bitmap bitmapOrig, bitmapChanged, bitmapWrited, bitmapDiff;
        const int formwidth = 1224;

        public F()
        {
            InitializeComponent();
        }

        private void Bopen_Click(object sender, EventArgs e)
        {
            HashSet<char> hs = new HashSet<char>();
            for (byte i = 48; i < 58; i++)
                hs.Add((char)i);
            for (byte i = 65; i < 91; i++)
                hs.Add((char)i);
            for (byte i = 97; i < 123; i++)
                hs.Add((char)i);

            OFD.InitialDirectory = "L:\\Лекции\\4 Курс\\Информационная безопасность\\Лабы\\images_lab_6";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                bitmapWrited = null;
                bitmapOrig = new Bitmap(Image.FromFile(OFD.FileName));
                if (OFD.ShowDialog() == DialogResult.OK)
                    bitmapChanged = new Bitmap(Image.FromFile(OFD.FileName));

                PB1.Image = bitmapOrig;
                PB1.Height = bitmapOrig.Height;
                PB1.Width = bitmapOrig.Width;

                PB2.Visible = false;
                PB3.Visible = false;

                this.Height = PB1.Height + 2;
                this.Width = PB1.Width > formwidth ? PB1.Width + 2 : formwidth + 2;

            }
        }

        private void Bstart_Click(object sender, EventArgs e)
        {
            while (true)
            {
                bitmapDiff = new Bitmap(bitmapOrig);

                if (bitmapOrig.Width != bitmapChanged.Width || bitmapOrig.Height != bitmapChanged.Height)
                    try
                    { }
                    catch
                    {
                        MessageBox.Show("Разные изображения!");
                        break;
                    }
                byte[] arr1 = new byte[bitmapOrig.Height * bitmapOrig.Width];
                byte[] arr2 = new byte[bitmapOrig.Height * bitmapOrig.Width];
                for (int i = 0; i < bitmapOrig.Height; i++)
                    LB1.Items.Add("" + (i + 1));
                for (int i = 0; i < bitmapOrig.Width; i++)
                    LB2.Items.Add("" + (i + 1));
                LB1.SelectedIndex = 0; LB2.SelectedIndex = 0;

                if (RBb.Checked)
                {
                    for (int i = 0; i < bitmapOrig.Height; i++)
                        for (int j = 0; j < bitmapOrig.Width; j++)
                            arr1[i * bitmapOrig.Width + j] = bitmapOrig.GetPixel(j, i).B;

                    for (int i = 0; i < bitmapOrig.Height; i++)
                        for (int j = 0; j < bitmapOrig.Width; j++)
                            arr2[i * bitmapOrig.Width + j] = bitmapChanged.GetPixel(j, i).B;
                }
                if (RBr.Checked)
                {
                    for (int i = 0; i < bitmapOrig.Height; i++)
                        for (int j = 0; j < bitmapOrig.Width; j++)
                            arr1[i * bitmapOrig.Width + j] = bitmapOrig.GetPixel(j, i).R;

                    for (int i = 0; i < bitmapOrig.Height; i++)
                        for (int j = 0; j < bitmapOrig.Width; j++)
                            arr2[i * bitmapOrig.Width + j] = bitmapChanged.GetPixel(j, i).R;
                }
                if (RBg.Checked)
                {
                    for (int i = 0; i < bitmapOrig.Height; i++)
                        for (int j = 0; j < bitmapOrig.Width; j++)
                            arr1[i * bitmapOrig.Width + j] = bitmapOrig.GetPixel(j, i).G;

                    for (int i = 0; i < bitmapOrig.Height; i++)
                        for (int j = 0; j < bitmapOrig.Width; j++)
                            arr2[i * bitmapOrig.Width + j] = bitmapChanged.GetPixel(j, i).G;
                }

                for (int i = 0; i < bitmapOrig.Height; i++)
                    for (int j = 0; j < bitmapOrig.Width; j++)
                        if (arr1[i * bitmapOrig.Width + j] - arr2[i * bitmapOrig.Width + j] == 0)
                            bitmapDiff.SetPixel(j, i, Color.White);

                TB2.Visible = false;
                PB2.Visible = true;
                PB2.Image = bitmapDiff;
                PB2.Height = bitmapDiff.Height;
                PB2.Width = bitmapDiff.Width;
                PB2.Location = new Point(PB1.Location.X + PB1.Width + 2, PB2.Location.Y);
                this.Width = PB1.Width + PB2.Width + 2;

                break;
            }
        }

        private void Bwrite_Click(object sender, EventArgs e)
        {
            while (true)
            {
                for (int i = 0; i < TB.Text.Length; i++)
                    if (((byte)TB.Text[i]) > 255)
                    {
                        MessageBox.Show("Символ " + TB.Text[i] + " не попадает в границы byte!");
                        break;
                    }

                if (TB.Text.Length > 0)
                {
                    int h = Int32.Parse(LB1.SelectedItem.ToString()) - 1,
                        w = Int32.Parse(LB2.SelectedItem.ToString()) - 1;
                    if (bitmapWrited == null)
                        bitmapWrited = new Bitmap(bitmapOrig);
                    if (w + TB.Text.Length - 1 <= PB1.Width)
                    {
                        for (int i = w; i < w + TB.Text.Length; i++)
                        {
                            Color c = bitmapWrited.GetPixel(i, h);
                            byte lol = (byte)TB.Text[i - w];
                            if (RBb.Checked)
                            {
                                bitmapWrited.SetPixel(i, h, Color.FromArgb(c.A, c.R, c.G, (byte)TB.Text[i - w]));
                            }
                            if (RBr.Checked)
                            {
                                bitmapWrited.SetPixel(i, h, Color.FromArgb(c.A, (byte)TB.Text[i - w], c.G, c.B));
                            }
                            if (RBg.Checked)
                            {
                                bitmapWrited.SetPixel(i, h, Color.FromArgb(c.A, c.R, (byte)TB.Text[i - w], c.B));
                            }
                        }
                    }

                    PB3.Image = bitmapWrited;
                    PB3.Visible = true;
                    PB3.Height = bitmapWrited.Height;
                    PB3.Width = bitmapWrited.Width;
                    PB3.Location = new Point(PB1.Location.X, PB1.Location.Y + PB1.Height + 2);
                    this.Height = PB1.Height + PB3.Height + 2;
                }
                break;
            }
        }

        private void Bsave_Click(object sender, EventArgs e)
        {
            if (bitmapWrited != null)
            {
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    PB3.Image.Save(SFD.FileName + (SFD.FileName[SFD.FileName.Length - 4] == '.' ? "" : OFD.FileName.Substring(OFD.FileName.Length - 4)));
                }
            }
            else
                MessageBox.Show("Картинка не изменена!");

        }

        private void F_Resize(object sender, EventArgs e)
        {
            //TB.Height = this.
            //TB.Width = PB1.Width * 3;
        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            bitmapWrited = null;
            PB3.Visible = false;
        }

        private void Bread_Click(object sender, EventArgs e)
        {//чет так себе работает чтение...
            for (int i = 0; i < 30; i++)
            {
                TB2.Text += "" + (i + 1) + ")";
                for (int j = 0; j < bitmapChanged.Width; j++)
                {
                    if (RBr.Checked)
                    {
                        if (bitmapChanged.GetPixel(j, i).R == bitmapOrig.GetPixel(j, i).R)
                            TB2.Text += "_";
                        else
                            TB2.Text += (char)bitmapChanged.GetPixel(i, j).R;
                    }
                    if (RBg.Checked)
                    {
                        if (bitmapChanged.GetPixel(j, i).G == bitmapOrig.GetPixel(j, i).G)
                            TB2.Text += "_";
                        else
                        TB2.Text += (char)bitmapChanged.GetPixel(i, j).G;
                    }
                    if (RBb.Checked)
                    {
                        if (bitmapChanged.GetPixel(j, i).B == bitmapOrig.GetPixel(j, i).B)
                            TB2.Text += "_";
                        else
                        TB2.Text += (char)bitmapChanged.GetPixel(i, j).B;
                    }
                }
                TB2.Text += Environment.NewLine;

            }

            TB2.Visible = true;
            TB2.Location = new Point(PB2.Location.X, PB2.Location.Y + PB2.Height + 2);
            this.Height = PB1.Height + TB2.Height + 2;
        }

    }
}
