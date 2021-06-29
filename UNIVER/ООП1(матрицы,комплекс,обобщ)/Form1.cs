using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Matrix<double> d1, d2, d3;
        Matrix<Complex> c1, c2, c3;
        public bool D;
        private void NewMat(string s, Matrix<double> d)
        {
            string tmp = "";
            int z = 0;
            for (int i = 0; i < d.Height; i++)
            {
                for (int j = 0; j < d.Wigth; j++)
                {
                    while (z < s.Length && s[z] != ',')
                    {
                        tmp += s[z];
                        z++;
                    }
                    z++;
                    d[i, j] = Double.Parse(tmp);
                    tmp = "";
                }
            }
        }

        private void NewMat(string s, Matrix<Complex> c)
        {
            int z = 0;
            //bool im = false;
            for (int i = 0; i < c.Height; i++)
            {
                for (int j = 0; j < c.Wigth; j++)
                {
                    string tmp = "", tmp2 = "";
                    while (z < s.Length && s[z] != ',')
                    {
                        tmp += s[z];
                        z++;
                    }
                    z++;
                    //double a, b;
                    int z2 = 0;
                    while (tmp[z2] != '+' && tmp[z2] != '-' && z2 < tmp.Length)
                    {
                        tmp2 += tmp[z2];
                        z2++;
                    }
                    c[i, j].Re = Double.Parse(tmp2);
                    if (z2 == tmp.Length)
                    {
                        c[i, j].Im = 0;
                    }
                    else
                    {
                        int znak = 0;
                        if (tmp[z2] == '+') znak = 1;
                        if (tmp[z2] == '-') znak = -1;
                        z2++;
                        tmp2 = "";
                        while (tmp[z2] != 'i')
                        {
                            if (z2 == tmp.Length) throw new MyExp("Куда дел i после " + tmp2 + "?");
                            tmp2 += tmp[z2];
                            z2++;
                        }
                        if (tmp2 != "") c[i, j].Im = Double.Parse(tmp2) * znak;
                        else c[i, j].Im = znak;
                    }
                }
            }
        }

        private string WriteMat(Matrix<double> d)
        {
            string s = "";
            for (int i = 0; i < d.Height; i++)
            {
                for (int j = 0; j < d.Wigth; j++)
                {
                    s += d[i, j] + " ";
                }
                s += Environment.NewLine;
            }
            return s;
        }
        private string WriteMat(Matrix<Complex> c)
        {
            string s = "";
            for (int i = 0; i < c.Height; i++)
            {
                for (int j = 0; j < c.Wigth; j++)
                {
                    s += c[i, j].ToString() + " ";
                }
                s += Environment.NewLine;
            }
            return s;
        }
        private void Mat1_Click(object sender, EventArgs e)
        {
            if (D)
            {
                d1 = new Matrix<double>(Int32.Parse(H1.Text), Int32.Parse(W1.Text));
                NewMat(M1.Text, d1);
                M1.Text = WriteMat(d1);
            }
            else
            {
                c1 = new Matrix<Complex>(Int32.Parse(H1.Text), Int32.Parse(W1.Text));
                for (int i = 0; i < c1.Height; i++)
                {
                    for (int j = 0; j < c1.Wigth; j++)
                    {
                        c1[i,j]=new Complex();
                    }
                }
                NewMat(M1.Text, c1);
                M1.Text = WriteMat(c1);
            }
        }

        private void Mat2_Click(object sender, EventArgs e)
        {
            if (D)
            {
                d2 = new Matrix<double>(Int32.Parse(H2.Text), Int32.Parse(W2.Text));
                NewMat(M2.Text, d2);
                M2.Text = WriteMat(d2);
            }
            else
            {
                c2 = new Matrix<Complex>(Int32.Parse(H2.Text), Int32.Parse(W2.Text));
                for (int i = 0; i < c2.Height; i++)
                {
                    for (int j = 0; j < c2.Wigth; j++)
                    {
                        c2[i, j] = new Complex();
                    }
                }
                NewMat(M2.Text, c2);
                M2.Text = WriteMat(c2);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (D)
                switch (Oper.Text)
                {
                    case ("+"):
                        {
                            d3 = d1 + d2;
                            Win.Text = WriteMat(d3);
                            break;
                        };
                    case ("-"):
                        {
                            d3 = d1 - d2;
                            Win.Text = WriteMat(d3);
                            break;
                        };
                    case ("*"):
                        {
                            d3 = d1 * d2;
                            Win.Text = WriteMat(d3);
                            break;
                        };
                    case ("/"):
                        {
                            Oper.Text = "";
                            throw new MyExp("Делить нельзя!");
                            //break;
                        };
                    default:
                        {
                            Oper.Text = "";
                            throw new MyExp("Знак неопределен!");
                            //break;
                        };
                }
            else
                switch (Oper.Text)
                {
                    case ("+"):
                        {
                            c3 = c1 + c2;
                            Win.Text = WriteMat(c3);
                            break;
                        };
                    case ("-"):
                        {
                            c3 = c1 - c2;
                            Win.Text = WriteMat(c3);
                            break;
                        };
                    case ("*"):
                        {
                            c3 = c1 * c2;
                            Win.Text = WriteMat(c3);
                            break;
                        };
                    case ("/"):
                        {
                            Oper.Text = "";
                            throw new MyExp("Делить нельзя!");
                            //break;
                        };
                    default:
                        {
                            Oper.Text = "";
                            throw new MyExp("Знак неопределен!");
                            //break;
                        };
                };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            D = true;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            D = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        //public Matrix<double> d1 { get; set; }
    }
}
