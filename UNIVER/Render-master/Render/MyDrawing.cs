using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Render
{

    public static class MyDrawing
    {
        //Для составляющих безтекстурной модели
        public static int redOne = 200, greenOne = 102, blueOne = 70;
        //Точки, полигоны, текстурные точки, текстура
        private static Tuple<Structures.MyPoint[], Structures.MyPolygon[], Structures.MyTPoint[], Bitmap> _MainData;
        //Размеры текстуры
        private static int width, height;
        //Отрисовка ребер
        private static bool edgesOnly; 
        //Режим отрисовки
        public static SmoothingMode HD = SmoothingMode.Default;

        #region Отрисовка
        //Канвасы отрисовки
        public static Graphics TempGraphics;
        public static Bitmap Canvas;
        private static int  //Размеры окна
          windowWidth = 0,   //Ширина
          windowHeigth = 0;
        public static double
          fxc = 0,
          fyc = 0,
          fzc = 0.5,
          leftXViewingBoundary = -2,
          rightXViewingBoundary = 2,
          upperYViewingBoundary = -2,
          lowerYViewingBoundary = 2;
        public static double alphaAngle = Math.PI, betaAngle = 0;
        #endregion

        //Видимы нормали
        public static bool hasNormalsVisible = false;

        //Устанавливает размеры окна
        public static void SetMonitor(int X, int Y)
        {
            windowWidth = X;
            windowHeigth = Y;
        }
        //Смена режима отрисовки
        public static void SetState(bool Edges)
        {
            edgesOnly = Edges;
        }
        //Установка массивов и текстуры
        public static void GetData(Tuple<Structures.MyPoint[], Structures.MyPolygon[], Structures.MyTPoint[], Bitmap> Data)
        {
            _MainData = Data;
            if (Data.Item4 != null)
            {
                width = Data.Item4.Width;
                height = Data.Item4.Height;
            }
        }
        //Изменение размеров окна
        public static void ChangeWindowXY(int u, int v, int Delta)
        {
            double coeff;
            double x = XX(u);
            double y = YY(v);
            if (Delta < 0)
                coeff = 1.03;
            else
                coeff = 0.97;
            leftXViewingBoundary = x - (x - leftXViewingBoundary) * coeff;
            rightXViewingBoundary = x + (rightXViewingBoundary - x) * coeff;
            upperYViewingBoundary = y - (y - upperYViewingBoundary) * coeff;
            lowerYViewingBoundary = y + (lowerYViewingBoundary - y) * coeff;
        }
        //Перевод координат 1
        private static double XX(int I)
        {
            return leftXViewingBoundary + I * (rightXViewingBoundary - leftXViewingBoundary) / windowWidth;
        }
        //Перевод координат 2
        private static double YY(int J)
        {
            return lowerYViewingBoundary + J * (upperYViewingBoundary - lowerYViewingBoundary) / windowHeigth;
        }
        //Движение окна
        public static void SetDelta(MouseEventArgs e0, MouseEventArgs e)
        {
            double dx = XX(e.X) - XX(e0.X);
            double dy = YY(e.Y) - YY(e0.Y);
            leftXViewingBoundary -= dx;
            upperYViewingBoundary -= dy;
            rightXViewingBoundary -= dx;
            lowerYViewingBoundary -= dy;
        }

        //Отрисовка
        public static void Draw()
        {
            if (edgesOnly)
                _Draw(new _DelSwitch(DrawEdge));
            else
                _Draw(new _DelSwitch(DrawPolygon));
        }

        //Отрисовка по делегату
        private static void _Draw(_DelSwitch Del)
        {
            using (Graphics g = Graphics.FromImage(Canvas))
            {
                MainUnitProcessor.Model.InvokeAlgorithms();
                g.Clear(Color.Black);
                Point P0, P1;
                P0 = TR32(new Structures.MyPoint(-3, 0, 0));
                P1 = TR32(new Structures.MyPoint(3, 0, 0));
                g.DrawLine(Pens.Red, P0, P1);
                P0 = TR32(new Structures.MyPoint(0, -3, 0));
                P1 = TR32(new Structures.MyPoint(0, 3, 0));
                g.DrawLine(Pens.Green, P0, P1);
                P0 = TR32(new Structures.MyPoint(0, 0, -3));
                P1 = TR32(new Structures.MyPoint(0, 0, 3));
                g.DrawLine(Pens.Blue, P0, P1);
                Structures.MyPolygon[] Polygons = _MainData.Item2;
                for (int i = 0; i < MainUnitProcessor.Model.polygonLength; i++)
                    Del(Polygons[i]);
            }
        }
        //Делегат отрисовки
        private delegate void _DelSwitch(Structures.MyPolygon Pol);

        //Получение центрального цвета текстуры
        private static Color GetCentralColor(Structures.MyPolygon Pol)
        {
            int[] TPoints;
            if (Pol.Type == 3)
                TPoints = new int[] { Pol.firstTPoint, Pol.secondTPoint, Pol.thirdTPoint };
            else
                TPoints = new int[] { Pol.firstTPoint, Pol.secondTPoint, Pol.thirdTPoint, Pol.fourthTPoint };
            Tuple<int, int> TexturePoint = GetCenter(TPoints);
            return _MainData.Item4.GetPixel(TexturePoint.Item1, TexturePoint.Item2);
        }
        //Получение центральной точки полигона
        private static Tuple<int, int> GetCenter(int[] TPoints)
        {
            //Получаем центр масс для полигона
            int Number = 0;
            double xMass = 0, yMass = 0;
            for (int i = 0; i < TPoints.Length; i++, Number++)
            {
                xMass += _MainData.Item3[TPoints[i] - 1].x;
                yMass += _MainData.Item3[TPoints[i] - 1].y;
            }
            return Tuple.Create((int)(xMass / Number * _MainData.Item4.Width), (int)(yMass / Number * _MainData.Item4.Height));
        }
        //Отрисовка полигона цветом
        private static void DrawPolygon(Structures.MyPolygon Pol)
        {
            using (Graphics g = Graphics.FromImage(Canvas))
            {
                g.SmoothingMode = HD;
                Color fillingColor;
                if (_MainData.Item4 != null)
                {
                    Color textureColor = GetCentralColor(Pol);
                    fillingColor = Color.FromArgb(
                        (int)(Math.Abs(Pol.LightCoeff) * textureColor.R),
                    (int)(Math.Abs(Pol.LightCoeff) * textureColor.G),
                    (int)(Math.Abs(Pol.LightCoeff) * textureColor.B));
                }
                else
                {
                    fillingColor = Color.FromArgb(
                        (int)((255 * Math.Abs(Pol.LightCoeff) + redOne) / 2),
                    (int)((255 * Math.Abs(Pol.LightCoeff) + greenOne) / 2),
                    (int)((255 * Math.Abs(Pol.LightCoeff) + blueOne) / 2));
                }

                SolidBrush Brush = new SolidBrush(fillingColor);

                Point P0 = TR32(_MainData.Item1[Pol.firstPoint - 1]);
                Point P1 = TR32(_MainData.Item1[Pol.secondPoint - 1]);
                Point P2 = TR32(_MainData.Item1[Pol.thirdPoint - 1]);
                if (Pol.Type == 3)
                    g.FillPolygon(Brush, new Point[] { P0, P1, P2 });
                else
                {
                    Point P3 = TR32(_MainData.Item1[Pol.fourthPoint - 1]);
                    g.FillPolygon(Brush, new Point[] { P0, P1, P2, P3 });
                }
                if (hasNormalsVisible)
                    g.DrawLine(Pens.Red, TR32(_MainData.Item1[Pol.firstPoint - 1]), TR32(new Structures.MyPoint(Pol.Vector[0], Pol.Vector[1], Pol.Vector[2])));
            }
        }
        //Отрисовка полигона ребрами
        private static void DrawEdge(Structures.MyPolygon Pol)
        {
            using (Graphics g = Graphics.FromImage(Canvas))
            {
                Point P0 = TR32(_MainData.Item1[Pol.firstPoint - 1]);
                Point P1 = TR32(_MainData.Item1[Pol.secondPoint - 1]);
                Point P2 = TR32(_MainData.Item1[Pol.thirdPoint - 1]);
                if (Pol.Type == 3)
                    g.DrawPolygon(Pens.White, new Point[] { P0, P1, P2 });
                else
                {
                    Point P3 = TR32(_MainData.Item1[Pol.fourthPoint - 1]);
                    g.DrawPolygon(Pens.White, new Point[] { P0, P1, P2, P3 });
                }
            }
        }
        //Перевод 3D в 2D
        private static Point TR32(Structures.MyPoint TempPoint)
        {
            const double empyricParam = -0.2;
            double realXCoord = (TempPoint.x - fxc) * Math.Cos(alphaAngle) - (TempPoint.y - fyc) * Math.Sin(alphaAngle);
            double realYCoord = ((TempPoint.x - fxc) * Math.Sin(alphaAngle) +
                (TempPoint.y - fyc) * Math.Cos(alphaAngle)) * Math.Cos(betaAngle) -
                (TempPoint.z - fzc) * Math.Sin(betaAngle);
            double realZCoord = ((TempPoint.x - fxc) * Math.Sin(alphaAngle) +
                (TempPoint.y - fyc) * Math.Cos(alphaAngle)) * Math.Sin(betaAngle) +
                (TempPoint.z - fzc) * Math.Cos(betaAngle);
            realXCoord /= realZCoord * empyricParam + 1;
            realYCoord /= realZCoord * empyricParam + 1;
            int imaginaryXCoord = (int)Math.Round(windowWidth * (realXCoord - leftXViewingBoundary) / (rightXViewingBoundary - leftXViewingBoundary));
            int Y = Convert.ToInt32(windowHeigth * (realYCoord - lowerYViewingBoundary) / (upperYViewingBoundary - lowerYViewingBoundary));
            return new Point(imaginaryXCoord, Y);
        }
    }
}