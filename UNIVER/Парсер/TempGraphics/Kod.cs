using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TempGraphics
{
  
  class Kod
  {
    public double[,] Matr = new double[4, 4];
    public double x1p = -20, y1p = -10, x2p = 20, y2p = 10; //Будем считать, что это изначальное полотно                  
    public int I1 = 0, J1 = 0, I2 = 0, J2 = 0;  //Экранные координаты изначально не заданы // Высота         
    double x0 = 0, y0 = 0, z0 = 0;
    public double HeightByTwo = 550, WidthByTwo = 280;
    public double Dist = 300, fxc = 0.5,
      fyc = 0.5,
      fzc = 0.5,
      Xmin = -2,
      Xmax = 2,
      Ymin = -2,
      Ymax = 2;
    double Alf, Bet;

    public Bitmap Canv;
    MyPoint[] Points;
    MyEdge[] Edges;
    MyPolygon[] Polygons;
    public int PLength;
    public int ELength;
    public int RLength;
    public Kod()
    {
      Points = new MyPoint[0];
      PLength = 0;
      Edges = new MyEdge[0];
      ELength = 0;
      Polygons = new MyPolygon[0];
      RLength = 0;
    }
    public void GeLoTVPoint(MyPoint Input, out double Outx, out double Outy)
    {
      double cos = Math.Cos(Alf);
      double sin = Math.Sin(Alf);

      double x = Input.X;
      double y = Input.Y;
      double z = Input.Z;
      x = (x - x0) * cos - (y - y0) * sin;
      y = ((x - x0) * sin + (y - y0) * cos) * cos - (z - z0) * sin;
      z = ((x - x0) * sin + (y - y0) * cos) * sin + (z - z0) * cos;
      Outx = x / ((z / 0.5) + 1);
      Outy = y / ((z / 0.5) + 1);
    }
    public void SetAngle(double x, double y)
    {
      Alf = Math.Atan2(y, x);
      Bet = Math.Sqrt((x / 10) * (x / 10) + (y / 10) * (y / 10));
    }
    public void Parse(string Input)
    {
      string[] Arr = Input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
      int Length = Arr.Length;
      string[] Row;
      for (int i = 0; i < Length; i++)
      {
        if (Arr[i] != "" && Arr[i][0] != '#')
          switch (Arr[i].Substring(0, 2))
          {
            case "v ":
              Row = Arr[i].Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
              Array.Resize(ref Points, ++PLength);
              Points[PLength - 1] = new MyPoint(
                double.Parse(Row[1], System.Globalization.CultureInfo.InvariantCulture),
                double.Parse(Row[2], System.Globalization.CultureInfo.InvariantCulture),
                double.Parse(Row[3], System.Globalization.CultureInfo.InvariantCulture));
              break;
            case "f ":
              Row = Arr[i].Split(' ');
              string[] Temp;
              int[] F = new int[3];
              for (int k = 1; k <= 3; k++)
              {
                Temp = Row[k].Split('/');
                F[k - 1] = int.Parse(Temp[0]);
              }
              Array.Resize(ref Polygons, ++RLength);
              Polygons[RLength - 1] = new MyPolygon(F[0], F[1], F[2]);
              Array.Resize(ref Edges, ELength + 3);
              ELength += 3;
              Edges[ELength - 3] = new MyEdge(F[0], F[1]);
              Edges[ELength - 2] = new MyEdge(F[1], F[2]);
              Edges[ELength - 1] = new MyEdge(F[2], F[0]);
              break;
          }
      }
    }

    
    public void Draw()
    {
      using (Graphics g = Graphics.FromImage(Canv))
      {
        g.Clear(Color.Black);
        Point P0, P1;
        P0 = IJ(new MyPoint(-30, 0, 0));
        P1 = IJ(new MyPoint(30, 0, 0));
        g.DrawLine(Pens.Red, P0, P1);
        P0 = IJ(new MyPoint(0, -300, 0));
        P1 = IJ(new MyPoint(0, 100, 0));
        g.DrawLine(Pens.Green, P0, P1);
        P0 = IJ(new MyPoint(0, 0, -30));
        P1 = IJ(new MyPoint(0, 0, 30));
        g.DrawLine(Pens.Blue, P0, P1);
        for (int i = 0; i < ELength; i++)
        {
          P0 = IJ(Points[Edges[i].FirstP - 1]); // 0*0
          P1 = IJ(Points[Edges[i].SecondP - 1]);
          g.DrawLine(Pens.White, P0, P1);
        }
      }
    }
    MyPoint Rotate(MyPoint P)
    {
      MyPoint Result = new MyPoint((P.X - fxc) * Math.Cos(Alf) - (P.Y - fyc) * Math.Sin(Alf),
        ((P.X - fxc) * Math.Sin(Alf) + (P.Y - fyc) * Math.Cos(Alf)) * Math.Cos(Bet) - (P.Z - fzc) * Math.Sin(Bet),
        ((P.X - fxc) * Math.Sin(Alf) + (P.Y - fyc) * Math.Cos(Alf)) * Math.Sin(Bet) + (P.Z - fzc) * Math.Cos(Bet));
      return Result;
    }
    private Point IJ(MyPoint P)
    {
      double Xn = (P.X - fxc) * Math.Cos(Alf) - (P.Y - fyc) * Math.Sin(Alf);
      double Yn = ((P.X - fxc) * Math.Sin(Alf) + (P.Y - fyc) * Math.Cos(Alf)) * Math.Cos(Bet) - (P.Z - fzc) * Math.Sin(Bet);
      double Zn = ((P.X - fxc) * Math.Sin(Alf) + (P.Y - fyc) * Math.Cos(Alf)) * Math.Sin(Bet) + (P.Z - fzc) * Math.Cos(Bet);
      //Xn = Xn / (Zn * FA + 1);
      //Yn = Yn / (Zn * FA + 1);
      int X = (int)Math.Round(I2 * (Xn - Xmin) / (Xmax - Xmin));
      int Y = (int)Convert.ToInt32(J2 * (Yn - Ymax) / (Ymin - Ymax));
      return new Point(X, Y);
    }
    public void SetDelta(MouseEventArgs e0, MouseEventArgs e)
    {
      double dx = XX(e.X) - XX(e0.X);
      double dy = YY(e.Y) - YY(e0.Y);
      Xmin -= dx;
      Ymin -= dy;
      Xmax -= dx;
      Ymax -= dy;
    }
    public void ChangeWindowXY(int u, int v, int Delta)
    {
      double coeff;
      double x = XX(u);
      double y = YY(v);
      if (Delta < 0)
        coeff = 1.03;
      else
        coeff = 0.97;
      Xmin = x - (x - Xmin) * coeff;
      Xmax = x + (Xmax - x) * coeff;
      Ymin = y - (y - Ymin) * coeff;
      Ymax = y + (Ymax - y) * coeff;
    }
    public void Redo(int MouseX, int MouseY, int OldCoordsX, int OldCoordsY)    //Движение изображения
    {
      double dx = XX(MouseX) - XX(OldCoordsX);
      double dy = YY(MouseY) - YY(OldCoordsY);

      x1p -= dx;
      y1p -= dy;
      x2p -= dx;
      y2p -= dy;
    }
    int II(double x)          //Перевод бумажного Х в экранный
    {
      return I1 + (int)((x - x1p) * (I2 - I1) / (x2p - x1p));
    }
    int JJ(double y)       //Перевод бумажного Y в экранный
    {
      return J1 + (int)((y - y1p) * (J1 - J2) / (y1p - y2p));
    }
    public double XX(int I)          //Перевод Х коры мыши в кору бумаги
    {
      return x1p + (I - I1) * (x2p - x1p) / (I2 - I1);
    }
    public double YY(int J)          //Перевод Ыгрыка мыши в кору бумаги
    {
      return y1p + (J - J1) * (y2p - y1p) / (J2 - J1);
    }
  }
  class MyPoint
  {
    public double X, Y, Z;
    public MyPoint(double x, double y, double z)
    {
      X = x;
      Y = y;
      Z = z;
    }
  }
  class MyEdge
  {
      public int FirstP, SecondP;
    public MyEdge(int a, int b)
    {
        FirstP = a;
        SecondP = b;
    }
  }
  class MyPolygon
  {
      public int FirstP, SecondP, ThirdP;
    public MyPolygon(int a, int b, int c)
    {
      FirstP = a;
      SecondP = b;
      ThirdP = c;
    }
  }
}
