using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace канва_1
{
    class kod
    {
        public static int z;
        public static int z1;
        public static int x1;
        public static int y1;
        public static Bitmap bit;
        public static void Draw(Graphics g)
        {
            Pen myPen = new Pen(Color.Red, 2);
            // myPen.PenType
            g.DrawLine(myPen, 10, 10, 100, 100);
        }
        public static void grafon(int x, int y, int r)
        {
            using (Graphics g = Graphics.FromImage(bit))
            {
                Pen myPen = new Pen(Color.Black);
                SolidBrush myBrush = new SolidBrush(Color.Black);
                switch (z1)
                {
                    case (1):
                        {
                            myPen = new Pen(Color.Red);
                            myBrush = new SolidBrush(Color.Red);
                            break;
                        };
                    case (2):
                        {
                            myPen = new Pen(Color.Green);
                            myBrush = new SolidBrush(Color.Green);
                            break;
                        };
                    case (3):
                        {
                            myPen = new Pen(Color.Blue);
                            myBrush = new SolidBrush(Color.Blue);
                            break;
                        };
                    case (4):
                        {
                            myPen = new Pen(Color.Yellow);
                            myBrush = new SolidBrush(Color.Yellow);
                            break;
                        };
                    case (5):
                        {
                            myPen = new Pen(Color.Brown);
                            myBrush = new SolidBrush(Color.Brown);
                            break;
                        };
                }
                switch (z)
                {
                    case (1):
                        {
                            g.DrawRectangle(myPen, x - r / 2, y - r / 2, r, r);
                            g.FillRectangle(myBrush, x - r / 2, y - r / 2, r, r);
                            break;
                        };
                    case (2):
                        {
                            g.DrawEllipse(myPen, x - r / 2, y - r / 2, r, r);
                            g.FillEllipse(myBrush, x - r / 2, y - r / 2, r, r);
                            break;
                        };
                   /* case (3):
                        {
                            g.
                            g.DrawRectangle(Pens.Black, x - 25, y - 25, 50, 50);
                            g.FillRectangle(Brushes.Red, x - 25, y - 25, 50, 50);
                            break;
                        };*/
                    case (4):
                        {
                            g.DrawRectangle(Pens.Black, x - 25, y - 25, 50, 50);
                            g.FillRectangle(Brushes.Red, x - 25, y - 25, 50, 50);
                            break;
                        };
                    case (5):
                        {
                            g.DrawRectangle(Pens.Black, x - 25, y - 25, 50, 50);
                            g.FillRectangle(Brushes.Red, x - 25, y - 25, 50, 50);
                            break;
                        };

                }
                /* else 
                 {
                     g.DrawString("БАТОН ЗАБЫЛ!", new Font("Arial", 20, FontStyle.Bold), Brushes.Yellow, x, y);
                 }*/
            }
        }

    }
}
