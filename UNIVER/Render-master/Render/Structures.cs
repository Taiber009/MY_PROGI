using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Render
{
    public class Structures
    {
        public class MyPoint
        {
            public double x, y, z;
            public double[] Vector;
            public MyPoint(double X, double Y, double Z)
            {
                x = X;
                y = Y;
                z = Z;
                Vector = new double[] { 0, 0, 0 };
            }
        }
        public class MyEdge
        {
            public int P1, P2;
            public MyEdge(int FP, int SP)
            {
                P1 = FP;
                P2 = SP;
            }
        }
        public class MyPolygon
        {
            public double cameraDist;
            public double cameraCoeff;
            public int firstPoint, secondPoint, thirdPoint, fourthPoint;
            public int firstTPoint, secondTPoint, thirdTPoint, fourthTPoint;
            public double MaxZ;
            public double[] Vector;
            public int Type;
            public double[] Equation;
            public double LightCoeff;
            public MyPolygon(int P1, int P2, int P3)
            {
                Type = 3;
                firstPoint = P1;
                secondPoint = P2;
                thirdPoint = P3;
            }
            public MyPolygon(int P1, int P2, int P3, int P4)
            {
                Type = 4;
                firstPoint = P1;
                secondPoint = P2;
                thirdPoint = P3;
                fourthPoint = P4;
            }
            public void SetTextures(int P1, int P2, int P3)
            {
                firstTPoint = P1;
                secondTPoint = P2;
                thirdTPoint = P3;
            }
            public void SetTextures(int P1, int P2, int P3, int P4)
            {
                firstTPoint = P1;
                secondTPoint = P2;
                thirdTPoint = P3;
                fourthTPoint = P4;
            }

        }
        public class MyTexture
        {
            public int firstPoint, secondPoint, thirdPoint, fourthPoint;
            public int Type;
            public MyTexture(int P1, int P2, int P3)
            {
                Type = 3;
                firstPoint = P1;
                secondPoint = P2;
                thirdPoint = P3;
            }
            public MyTexture(int P1, int P2, int P3, int P4)
            {
                Type = 4;
                firstPoint = P1;
                secondPoint = P2;
                thirdPoint = P3;
                fourthPoint = P4;
            }
        }
        public class MyTPoint
        {
            public double x, y;
            public MyTPoint(double X, double Y)
            {
                x = X;
                y = Y;
            }
        }
    }
}
