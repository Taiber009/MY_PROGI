using System;
using System.Drawing;

namespace Render
{
    public class ModelClass
    {
        public double xRotation = 0.0;
        public double yRotation = 0.0;
        public double zRotation = 0.0;
        private byte axisTurning;
        public Bitmap canv;
        public double[] lightVector;
        public double zoomCoeff;
        public int triangling;
        public byte zoomAxis;
        public bool triangulated;

        public double[] camera;
        
        public Structures.MyTPoint[] origTextures;
        public Structures.MyTPoint[] textures;
        public Structures.MyPoint[] origPoints;
        public Structures.MyPoint[] points;
        public Structures.MyPolygon[] origPolygons;
        public Structures.MyPolygon[] polygons;
        public Structures.MyPoint[] normals;
        public int normLength;
        public int pointsLength;
        public int polygonLength;
        public int texturesLength;
        public Structures.MyPoint modelCenter;
        public Bitmap texture;

        public ModelClass()
        {
            triangulated = false;
            origPoints = new Structures.MyPoint[0];
            pointsLength = 0;
            polygons = new Structures.MyPolygon[0];
            lightVector = new double[3] { 0, 0, 1 };
            polygonLength = 0;
            normals = new Structures.MyPoint[0];
            normLength = 0;
            origTextures = new Structures.MyTPoint[0];
            texturesLength = 0;
            camera = new double[3] { 0, 0, 100 };
            zoomCoeff = 1;
            axisTurning = 1;
            zoomAxis = 1;
            triangling = 1;
        }
        //Загрузка текстуры
        public void SetTexture(Bitmap bitm)
        {
            texture = bitm;
            texture.RotateFlip(RotateFlipType.Rotate180FlipNone);
            SendData();
        }
        //На сколько вращать
        public void SetTurning(double Angle)
        {
            switch (axisTurning)
            {
                case 1:
                    xRotation = Angle;
                    yRotation = zRotation = 0;
                    break;
                case 2:
                    yRotation = Angle;
                    xRotation = zRotation = 0;
                    break;
                case 3:
                    zRotation = Angle;
                    yRotation = xRotation = 0;
                    break;
            }
        }
        //Вокруг чего вращать
        public void SetAxisTurn(byte Axis)
        {
            axisTurning = Axis;
        }
        //Отправка данных в отрисовку
        public void SendData()
        {
            MyDrawing.GetData(Tuple.Create(points, polygons, textures, texture));
        }
        //Парсинг файла
        public void Parse(string Input)
        {
            double X, Y, Z;
            string[] Arr = Input.Split(new string[] { "\n\r", "\n" }, StringSplitOptions.None);
            int Length = Arr.Length;
            string[] Row;
            bool flag = true;
            int FType = 1;  //1 - _ 2 - _/_ 3 - _/_/_ 4 - _//_

            double maxX = double.MinValue;
            double maxY = double.MinValue;
            double maxZ = double.MinValue;

            double MaxTexture = double.MinValue;

            for (int i = 0; i < Length; i++)
            {
                if (Arr[i] != "" && Arr[i][0] != '#')
                    switch (Arr[i].Substring(0, 2))
                    {
                        case "v ":
                            Row = Arr[i].Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
                            Array.Resize(ref origPoints, ++pointsLength);
                            X = double.Parse(Row[1], System.Globalization.CultureInfo.InvariantCulture);
                            Y = double.Parse(Row[2], System.Globalization.CultureInfo.InvariantCulture);
                            Z = double.Parse(Row[3], System.Globalization.CultureInfo.InvariantCulture);
                            if (maxX < X)
                                maxX = X;
                            if (maxY < Y)
                                maxY = Y;
                            if (maxZ < Z)
                                maxZ = Z;
                            origPoints[pointsLength - 1] = new Structures.MyPoint(X, Y, Z);
                            break;
                        case "vn":
                            Row = Arr[i].Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
                            X = double.Parse(Row[1], System.Globalization.CultureInfo.InvariantCulture);
                            Y = double.Parse(Row[2], System.Globalization.CultureInfo.InvariantCulture);
                            Z = double.Parse(Row[3], System.Globalization.CultureInfo.InvariantCulture);
                            Array.Resize(ref normals, ++normLength);
                            normals[normLength - 1] = new Structures.MyPoint(X, Y, Z);
                            break;
                        case "f ":
                            if (flag)
                            {
                                if (Arr[i].IndexOf('/') != -1)
                                {
                                    string[] tmp = Arr[i].Split(' ');
                                    int Leng = tmp[1].Length;

                                    tmp = tmp[1].Split('/');

                                    if (tmp[1][0] != '/')
                                        FType = tmp.Length;
                                    else
                                        FType = 4;
                                }
                                else
                                    FType = 5;
                                flag = false;
                            }
                            Row = Arr[i].Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
                            int RowLength = Row.Length - 1;
                            string[] Temp;
                            int[] F = new int[Row.Length - 1];
                            int[] N = new int[Row.Length - 1];
                            int[] T = new int[Row.Length - 1];
                            switch (FType)
                            {
                                case 1:
                                    for (int k = 1; k <= RowLength; k++)
                                        F[k - 1] = int.Parse(Row[k]);
                                    break;
                                case 2:
                                    for (int k = 1; k <= RowLength; k++)
                                    {
                                        Temp = Row[k].Split('/');
                                        F[k - 1] = int.Parse(Temp[0]);
                                        T[k - 1] = int.Parse(Temp[1]);
                                    }
                                    break;
                                case 3:
                                    for (int k = 1; k <= RowLength; k++)
                                    {
                                        Temp = Row[k].Split('/');
                                        F[k - 1] = int.Parse(Temp[0]);
                                        T[k - 1] = int.Parse(Temp[1]);
                                        N[k - 1] = int.Parse(Temp[2]);
                                    }
                                    break;
                                case 4:
                                    //Кек
                                    break;
                                case 5:
                                    for (int k = 1; k <= RowLength; k++)
                                        F[k - 1] = int.Parse(Row[k]);
                                    break;
                            }
                            Array.Resize(ref origPolygons, ++polygonLength);
                            if (RowLength == 3)
                            {
                                origPolygons[polygonLength - 1] = new Structures.MyPolygon(F[0], F[1], F[2]);
                                origPolygons[polygonLength - 1].SetTextures(T[0], T[1], T[2]);
                            }
                            else
                            {
                                origPolygons[polygonLength - 1] = new Structures.MyPolygon(F[0], F[1], F[2], F[3]);
                                origPolygons[polygonLength - 1].SetTextures(T[0], T[1], T[2], T[3]);
                            }
                            break;
                        case "vt":
                            Row = Arr[i].Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
                            double[] Te = new double[Row.Length - 1];
                            Te[0] = double.Parse(Row[1], System.Globalization.CultureInfo.InvariantCulture);
                            Te[1] = double.Parse(Row[2], System.Globalization.CultureInfo.InvariantCulture);
                            if (MaxTexture < Te[0])
                                MaxTexture = Te[0];
                            if (MaxTexture < Te[1])
                                MaxTexture = Te[1];
                            Array.Resize(ref origTextures, ++texturesLength);
                            origTextures[texturesLength - 1] = new Structures.MyTPoint(Te[0], Te[1]);
                            break;
                    }
            }
            maxX = Math.Abs(maxX);
            maxY = Math.Abs(maxY);
            maxZ = Math.Abs(maxZ);

            //Нормализация координат
            if (MaxTexture > 1)
                for (int i = 0; i < texturesLength; i++)
                {
                    origTextures[i].x /= MaxTexture;
                    origTextures[i].y /= MaxTexture;
                }
            if (maxX > 1 || maxY > 1 || maxZ > 1)
            {
                double Max = 0;
                if (maxX > maxY && maxY > maxZ)
                    Max = maxX;
                else
                    if (maxX < maxY && maxY > maxZ)
                        Max = maxY;
                    else
                        if (maxZ > maxX && maxX > maxY)
                            Max = maxZ;
                for (int i = 0; i < pointsLength; i++)
                {
                    origPoints[i].x /= Max;
                    origPoints[i].y /= Max;
                    origPoints[i].z /= Max;
                }
            }
		}
        //Вызов алгоритмов вращения, движения
        public void InvokeAlgorithms()
        {
            RotatePoints();
            if (triangulated)
                GetTriangularNormals();
            else
                GetVectorNormals();
            GetMaxZs();
            GetCoeffs();
            SortPolygons();
        }
        //Выдача коэффициентов удаления и света
        private void GetCoeffs()
        {
            for (int i = 0; i < polygonLength; i++)
            {
                polygons[i].LightCoeff = VectorOperations.GetCosBetweenVectors(
                  lightVector, polygons[i].Vector);
                polygons[i].cameraCoeff = VectorOperations.VectorGetLength(
                  camera, polygons[i].Vector);
            }
        }
        //Вращает точки
        private void RotatePoints()
        {
            Matrices.MatrixRotation RotX = new Matrices.MatrixRotation(xRotation, 1);
            Matrices.MatrixRotation RotY = new Matrices.MatrixRotation(yRotation, 2);
            Matrices.MatrixRotation RotZ = new Matrices.MatrixRotation(zRotation, 3);
            for (int i = 0; i < pointsLength; i++)
            {
                points[i] = VectorOperations.VectorMultiply(points[i], RotX);
                points[i] = VectorOperations.VectorMultiply(points[i], RotY);
                points[i] = VectorOperations.VectorMultiply(points[i], RotZ);
            }
        }
        //Деление четырехугольника
        private void DivideQuadPol(Structures.MyPolygon pol, Structures.MyPoint[] tempPoints, Structures.MyTPoint[] tempTextures, ref int L, ref int P, ref int T)
        {
            //Выдергиваем 4 точки полигона
            Structures.MyPoint point1 = tempPoints[pol.firstPoint - 1];
            Structures.MyPoint point2 = tempPoints[pol.secondPoint - 1];
            Structures.MyPoint point3 = tempPoints[pol.thirdPoint - 1];
            Structures.MyPoint point4 = tempPoints[pol.fourthPoint - 1];

            Structures.MyTPoint tPoint1 = tempTextures[pol.firstTPoint - 1];
            Structures.MyTPoint tPoint2 = tempTextures[pol.secondTPoint - 1];
            Structures.MyTPoint tPoint3 = tempTextures[pol.thirdTPoint - 1];
            Structures.MyTPoint tPoint4 = tempTextures[pol.fourthTPoint - 1];
            //Добавляем 5 новых
            Structures.MyPoint newPoint1 = new Structures.MyPoint(
                (point1.x + point2.x) / 2,
                (point1.y + point2.y) / 2,
                (point1.z + point2.z) / 2);
            newPoint1.Vector = VectorOperations.VectorLinearSum(point1.Vector, point2.Vector);
            Structures.MyPoint newPoint2 = new Structures.MyPoint(
                (point2.x + point3.x) / 2,
                (point2.y + point3.y) / 2,
                (point2.z + point3.z) / 2);
            newPoint2.Vector = VectorOperations.VectorLinearSum(point2.Vector, point3.Vector);
            Structures.MyPoint newPoint3 = new Structures.MyPoint(
                (point3.x + point4.x) / 2,
                (point3.y + point4.y) / 2,
                (point3.z + point4.z) / 2);
            newPoint3.Vector = VectorOperations.VectorLinearSum(point3.Vector, point4.Vector);
            Structures.MyPoint newPoint4 = new Structures.MyPoint(
                (point1.x + point4.x) / 2,
                (point1.y + point4.y) / 2,
                (point1.z + point4.z) / 2);
            newPoint4.Vector = VectorOperations.VectorLinearSum(point1.Vector, point4.Vector);
            Structures.MyPoint centerPoint = new Structures.MyPoint(
                (newPoint1.x + newPoint3.x) / 2,
                (newPoint1.y + newPoint3.y) / 2,
                (newPoint1.z + newPoint3.z) / 2);
            centerPoint.Vector = VectorOperations.VectorLinearSum(newPoint1.Vector, newPoint3.Vector);

            Structures.MyTPoint newTPoint1 = new Structures.MyTPoint(
                (tPoint1.x + tPoint2.x) / 2,
                (tPoint1.y + tPoint2.y) / 2);
            Structures.MyTPoint newTPoint2 = new Structures.MyTPoint(
                (tPoint2.x + tPoint3.x) / 2,
                (tPoint2.y + tPoint3.y) / 2);
            Structures.MyTPoint newTPoint3 = new Structures.MyTPoint(
                (tPoint3.x + tPoint4.x) / 2,
                (tPoint3.y + tPoint4.y) / 2);
            Structures.MyTPoint newTPoint4 = new Structures.MyTPoint(
                (tPoint1.x + tPoint4.x) / 2,
                (tPoint1.y + tPoint4.y) / 2);
            Structures.MyTPoint centerTPoint = new Structures.MyTPoint(
                (newTPoint1.x + newTPoint3.x) / 2,
                (newTPoint1.y + newTPoint3.y) / 2);
            //Заталкиваем в массив точек
            Array.Resize(ref points, ++L);
            points[L - 1] = point1;
            Array.Resize(ref points, ++L);
            points[L - 1] = point2;
            Array.Resize(ref points, ++L);
            points[L - 1] = point3;
            Array.Resize(ref points, ++L);
            points[L - 1] = point4;

            Array.Resize(ref points, ++L);
            points[L - 1] = newPoint1;
            Array.Resize(ref points, ++L);
            points[L - 1] = newPoint2;
            Array.Resize(ref points, ++L);
            points[L - 1] = newPoint3;
            Array.Resize(ref points, ++L);
            points[L - 1] = newPoint4;
            Array.Resize(ref points, ++L);
            points[L - 1] = centerPoint;

            pointsLength += 9;

            Array.Resize(ref textures, ++T);
            textures[T - 1] = tPoint1;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = tPoint2;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = tPoint3;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = tPoint4;

            Array.Resize(ref textures, ++T);
            textures[T - 1] = newTPoint1;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = newTPoint2;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = newTPoint3;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = newTPoint4;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = centerTPoint;

            texturesLength += 9;
            //Заталкиваем новые полигоны в общий массив
            Array.Resize(ref polygons, ++P);
            polygons[P - 1] = new Structures.MyPolygon(
                L - 8,
                L - 4,
                L,
                L - 1);
            polygons[P - 1].SetTextures(
                T - 8,
                T - 4,
                T,
                T - 1);
            polygons[P - 1].Vector = VectorOperations.VectorLinearAvg(
                  points[L - 9].Vector,
                  points[L - 5].Vector,
                  points[L - 1].Vector,
                  points[L - 2].Vector
                  );
            Array.Resize(ref polygons, ++P);
            polygons[P - 1] = new Structures.MyPolygon(
                L - 7,
                L - 3,
                L,
                L - 4);
            polygons[P - 1].SetTextures(
                T - 7,
                T - 3,
                T,
                T - 4);
            polygons[P - 1].Vector = VectorOperations.VectorLinearAvg(
                  points[L - 8].Vector,
                  points[L - 4].Vector,
                  points[L - 1].Vector,
                  points[L - 5].Vector
                  );
            Array.Resize(ref polygons, ++P);
            polygons[P - 1] = new Structures.MyPolygon(
                L - 3,
                L - 6,
                L - 2,
                L);
            polygons[P - 1].SetTextures(
                T - 3,
                T - 6,
                T - 2,
                T);
            polygons[P - 1].Vector = VectorOperations.VectorLinearAvg(
                  points[L - 4].Vector,
                  points[L - 7].Vector,
                  points[L - 3].Vector,
                  points[L - 1].Vector
                  );
            Array.Resize(ref polygons, ++P);
            polygons[P - 1] = new Structures.MyPolygon(
                L - 2,
                L - 5,
                L - 1,
                L);
            polygons[P - 1].SetTextures(
                T - 2,
                T - 5,
                T - 1,
                T);
            polygons[P - 1].Vector = VectorOperations.VectorLinearAvg(
                  points[L - 3].Vector,
                  points[L - 6].Vector,
                  points[L - 2].Vector,
                  points[L - 1].Vector
                  );
            polygonLength += 4;
        }
        //Деление треугольника
        private void DivideTriPol(Structures.MyPolygon pol, Structures.MyPoint[] tempPoints, Structures.MyTPoint[] tempTextures, ref int L, ref int P, ref int T)
        {
            //Вытягиваем три изначальные точки полигона
            Structures.MyPoint point1 = tempPoints[pol.firstPoint - 1];
            Structures.MyPoint point2 = tempPoints[pol.secondPoint - 1];
            Structures.MyPoint point3 = tempPoints[pol.thirdPoint - 1];

            Structures.MyTPoint tPoint1 = tempTextures[pol.firstTPoint - 1];
            Structures.MyTPoint tPoint2 = tempTextures[pol.secondTPoint - 1];
            Structures.MyTPoint tPoint3 = tempTextures[pol.thirdTPoint - 1];
            //Формируем точки на центрах граней
            Structures.MyPoint newPoint1 = new Structures.MyPoint(
                      (point1.x + point2.x) / 2,
                      (point1.y + point2.y) / 2,
                      (point1.z + point2.z) / 2);
            newPoint1.Vector = VectorOperations.VectorLinearSum(point1.Vector, point2.Vector);
            Structures.MyPoint newPoint2 = new Structures.MyPoint(
                (point2.x + point3.x) / 2,
                (point2.y + point3.y) / 2,
                (point2.z + point3.z) / 2);
            newPoint2.Vector = VectorOperations.VectorLinearSum(point3.Vector, point2.Vector);
            Structures.MyPoint newPoint3 = new Structures.MyPoint(
                (point3.x + point1.x) / 2,
                (point3.y + point1.y) / 2,
                (point3.z + point1.z) / 2);
            newPoint3.Vector = VectorOperations.VectorLinearSum(point1.Vector, point3.Vector);


            Structures.MyTPoint newTPoint1 = new Structures.MyTPoint(
                (tPoint1.x + tPoint2.x) / 2,
                (tPoint1.y + tPoint2.y) / 2);
            Structures.MyTPoint newTPoint2 = new Structures.MyTPoint(
                (tPoint2.x + tPoint3.x) / 2,
                (tPoint2.y + tPoint3.y) / 2);
            Structures.MyTPoint newTPoint3 = new Structures.MyTPoint(
                (tPoint3.x + tPoint1.x) / 2,
                (tPoint3.y + tPoint1.y) / 2);
            //Запихиваем эти точки в массив точек
            Array.Resize(ref points, ++L);
            points[L - 1] = point1;
            Array.Resize(ref points, ++L);
            points[L - 1] = point2;
            Array.Resize(ref points, ++L);
            points[L - 1] = point3;

            Array.Resize(ref points, ++L);
            points[L - 1] = newPoint1;
            Array.Resize(ref points, ++L);
            points[L - 1] = newPoint2;
            Array.Resize(ref points, ++L);
            points[L - 1] = newPoint3;

            pointsLength += 6;


            Array.Resize(ref textures, ++T);
            textures[T - 1] = tPoint1;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = tPoint2;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = tPoint3;

            Array.Resize(ref textures, ++T);
            textures[T - 1] = newTPoint1;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = newTPoint2;
            Array.Resize(ref textures, ++T);
            textures[T - 1] = newTPoint3;

            texturesLength += 6;
            //Запихиваем связанные полигоны в массив полигонов
            Array.Resize(ref polygons, ++P);
            polygons[P - 1] = new Structures.MyPolygon(
                L - 5,
                L - 2,
                L);
            polygons[P - 1].Vector = VectorOperations.VectorLinearAvg(
                  points[L - 6].Vector,
                  points[L - 3].Vector,
                  points[L - 1].Vector
                  );
            polygons[P - 1].SetTextures(
                T - 5,
                T - 2,
                T);
            Array.Resize(ref polygons, ++P);
            polygons[P - 1] = new Structures.MyPolygon(
                L - 2,
                L - 4,
                L - 1);
            polygons[P - 1].SetTextures(
                T - 2,
                T - 4,
                T - 1);
            polygons[P - 1].Vector = VectorOperations.VectorLinearAvg(
                  points[L - 3].Vector,
                  points[L - 5].Vector,
                  points[L - 2].Vector
                  );
            Array.Resize(ref polygons, ++P);
            polygons[P - 1] = new Structures.MyPolygon(
                L - 1,
                L - 3,
                L);
            polygons[P - 1].SetTextures(
                T - 1,
                T - 3,
                T);
            polygons[P - 1].Vector = VectorOperations.VectorLinearAvg(
                  points[L - 2].Vector,
                  points[L - 4].Vector,
                  points[L - 1].Vector
                  );
            Array.Resize(ref polygons, ++P);
            polygons[P - 1] = new Structures.MyPolygon(
                L - 2,
                L - 1,
                L);
            polygons[P - 1].SetTextures(
                T - 2,
                T - 1,
                T);
            polygons[P - 1].Vector = VectorOperations.VectorLinearAvg(
                  points[L - 3].Vector,
                  points[L - 2].Vector,
                  points[L - 1].Vector
                  );
        }
        //Пытаемся делить полигоны
        public void TryToDivide(int Step)
        {
            int PolL = origPolygons.Length;
            bool flag = false;
            int L = 0;
            int P = 0;
            int T = 0;
            //Если шаг триангуляции == 1
            if (Step == 1)
            {
                triangulated = false;
                polygons = origPolygons;
                points = origPoints;
                textures = origTextures;
                polygonLength = origPolygons.Length;
                pointsLength = origPoints.Length;
                GetVectorNormals();
            }
            //Иначе херачим деление в цикле
            else
            {
                triangulated = true;
                polygons = new Structures.MyPolygon[0];
                points = new Structures.MyPoint[0];
                Structures.MyPoint[] tempPoints = origPoints;
                Structures.MyPolygon[] tempPolygons = origPolygons;
                Structures.MyTPoint[] tempTextures = origTextures;
                for (int S = 1; S < Step; S++)
                { //Чтобы произошел первый сброс
                    if (!flag)
                    {
                        polygonLength = pointsLength = texturesLength = 0;
                        flag = true;
                    }
                    for (int i = 0; i < PolL; i++)
                    {

                        if (tempPolygons[i].Type == 3)
                            DivideTriPol(tempPolygons[i], tempPoints, tempTextures, ref L, ref P, ref T);
                        else
                            DivideQuadPol(tempPolygons[i], tempPoints, tempTextures, ref L, ref P, ref T);
                    }
                    tempPolygons = polygons;
                    tempPoints = points;
                    tempTextures = textures;
                    PolL = tempPolygons.Length;
                }
                polygonLength = polygons.Length;
                pointsLength = points.Length;
            }
            GetTriangularNormals();
        }
        //Установка точки источника света
        public void SetLightVector(double X, double Y, double Z)
        {
            lightVector = new double[3] { X, Y, Z };
        }
        //Получение нормалей полигонов неделенных
        private void GetVectorNormals()
        {
            for (int i = 0; i < polygonLength; i++)
            {
                polygons[i].Vector = VectorOperations.VectorCrossProduct(new double[] {
          points[polygons[i].secondPoint - 1].x - points[polygons[i].firstPoint - 1].x,
          points[polygons[i].secondPoint - 1].y - points[polygons[i].firstPoint - 1].y,
          points[polygons[i].secondPoint - 1].z - points[polygons[i].firstPoint - 1].z}, new double[] {
          points[polygons[i].thirdPoint - 1].x -  points[polygons[i].firstPoint - 1].x,
          points[polygons[i].thirdPoint - 1].y -  points[polygons[i].firstPoint - 1].y,
          points[polygons[i].thirdPoint - 1].z -  points[polygons[i].firstPoint - 1].z});
                polygons[i].Vector = VectorOperations.Normalize(polygons[i].Vector);
                points[polygons[i].firstPoint - 1].Vector = VectorOperations.VectorLinearSum(points[polygons[i].firstPoint - 1].Vector, polygons[i].Vector);
                points[polygons[i].secondPoint - 1].Vector = VectorOperations.VectorLinearSum(points[polygons[i].secondPoint - 1].Vector, polygons[i].Vector);
                points[polygons[i].thirdPoint - 1].Vector = VectorOperations.VectorLinearSum(points[polygons[i].thirdPoint - 1].Vector, polygons[i].Vector);
                if (polygons[i].Type == 4)
                    points[polygons[i].fourthPoint - 1].Vector = VectorOperations.VectorLinearSum(points[polygons[i].fourthPoint - 1].Vector, polygons[i].Vector);
            }
        }
        //Получение нормалей деленных полигонов
        private void GetTriangularNormals()
        {
            for (int i = 0; i < polygonLength; i++)
            {
                if (polygons[i].Type == 4)
                    polygons[i].Vector = VectorOperations.VectorLinearAvg(
                      points[polygons[i].firstPoint - 1].Vector,
                      points[polygons[i].secondPoint - 1].Vector,
                      points[polygons[i].fourthPoint - 1].Vector,
                      points[polygons[i].thirdPoint - 1].Vector
                      );
                else
                    polygons[i].Vector = VectorOperations.VectorLinearAvg(
                      points[polygons[i].firstPoint - 1].Vector,
                      points[polygons[i].secondPoint - 1].Vector,
                      points[polygons[i].thirdPoint - 1].Vector
                      );
            }
        }
        //Сортировка полигонов по удалению от камеры
        private void SortPolygons()
        {
            int j;
            int step = polygonLength / 2;
            while (step > 0)
            {
                for (int i = 0; i < (polygonLength - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (polygons[j].MaxZ >= polygons[j + step].MaxZ))
                    {
                        Structures.MyPolygon tmp = polygons[j];
                        polygons[j] = polygons[j + step];
                        polygons[j + step] = tmp;
                        j -= step;
                    }
                }
                step /= 2;
            }
        }
        //Для всех полигонов рассчитывает Z
        private void GetMaxZs()
        {
            for (int i = 0; i < polygonLength; i++)
                GetMaxZ(polygons[i]);
        }
        //Линейное изменение модели
        public void ZoomWithCoeffs(int Delta, double X, double Y, double Z)
        {
            Matrices.MatrixResizing Rez;
            Rez = new Matrices.MatrixResizing(Delta < 0, X, Y, Z);
            for (int i = 0; i < pointsLength; i++)
                origPoints[i] = VectorOperations.VectorMultiply(origPoints[i], Rez);
        }
        //Движение модели в координатах
        public void MoveWithCoeffs(int Delta, double X, double Y, double Z)
        {
            int mult = Delta < 0 ? 1 : -1;
            Matrices.MatrixTranslation Rez = new Matrices.MatrixTranslation(mult * X, mult * Y, mult * Z, true);
            for (int i = 0; i < pointsLength; i++)
                if(i<origPoints.Length)
                origPoints[i] = VectorOperations.VectorMultiply(origPoints[i], Rez);
        }
        //Взятие максимального Z для полигона
        private void GetMaxZ(Structures.MyPolygon Pol)
        {
            double Z1 = points[Pol.firstPoint - 1].z;
            double Z2 = points[Pol.secondPoint - 1].z;
            double Z3 = points[Pol.thirdPoint - 1].z;
            double[] Arr = new double[] { Z1, Z2, Z3 };
            if (Pol.Type == 4)
            {
                double Z4 = points[Pol.fourthPoint - 1].z;
                Arr = new double[] { Z1, Z2, Z3, Z4 };
            }
            Array.Sort(Arr);
            Pol.MaxZ = Pol.Type == 4 ? Arr[3] : Arr[2];
        }
    }
}