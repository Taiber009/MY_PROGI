using System;
using System.Text;

namespace OOP1
{
    public class Matrix<T>
    {
        private int wigth;
        private int height;

        public int Wigth
        {
            get
            {
                return wigth;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }
        private T[,] elem;

        //T Count(int x, int y)
        //{
        //    return elem[y, x];
        //}
        // IMathCalculator<T> MathCalculator;

        private void checkIndexes(int i, int j)
        {
            if (i < 0)
                throw new MyExp("Ошибка! Номер строки не может быть отрицательным!");
            if (j < 0)
                throw new MyExp("Ошибка! Номер столбца не может быть отрицательным!");
            if (i >= this.Height)
                throw new MyExp("Ошибка! Вы указали строчку " + (i + 1) + ", но в матрице всего " + this.Height + " строчек!");

            if (j >= this.Wigth)
                throw new MyExp("Ошибка! Вы указали столбец " + (j + 1) + ", но в матрице всего " + this.Wigth + " столбцов!");
        }

        public T this[int i, int j]
        {

            get
            {
                checkIndexes(i, j);
                return this.elem[i, j];
            }
            set
            {
                checkIndexes(i, j);
                this.elem[i, j] = value;
            }
        }

        static Matrix<T> FromArray(T[,] array)
        {
            Matrix<T> m = new Matrix<T>(array.GetLength(1), array.GetLength(2));
            for (int i = 0; i < m.Height; i++)
                for (int j = 0; j < m.Wigth; j++)
                    m.elem[i, j] = array[i, j];
            ///
            return m;
        }
        public Matrix(int x, int y)
        {
            wigth = x;
            height = y;
            elem = new T[y, x];
        }
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Wigth != m2.Wigth || m2.Height != m1.Height)
                throw new MyExp("Ошибка при сложении матриц! Размеры матриц должены быть равны!");
            else
                if (m1.Wigth == m2.Wigth && m2.Height == m1.Height)
                {
                Matrix<T> m0 = new Matrix<T>(m1.Height, m1.Wigth);
                for (int i = 0; i < m0.Height; i++)
                    for (int j = 0; j < m0.Wigth; j++)
                    {
                        dynamic a = m2.elem[i, j];
                        dynamic b = m1.elem[i, j];

                        m0.elem[i, j] = (T)(a + b);
                    }
                return m0;
            }
            return null;
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Wigth != m2.Wigth || m2.Height != m1.Height)
                throw new MyExp("Ошибка при вычитании матриц! Размеры матриц должены быть равны!");
            else
                if (m1.Wigth == m2.Wigth && m2.Height == m1.Height)
                {
                    Matrix<T> m0 = new Matrix<T>(m1.Height, m1.Wigth);
                    for (int i = 0; i < m0.Height; i++)
                        for (int j = 0; j < m0.Wigth; j++)
                        {
                            dynamic a = m2.elem[i, j];
                            dynamic b = m1.elem[i, j];

                            m0.elem[i, j] = (T)(a - b);
                        }
                    return m0;
                }
            return null;
        }
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Wigth != m2.Height)
                throw new MyExp("Ошибка при умножении матриц! Ширина первой не равна высоте второй!");
            else
                if (m1.Wigth == m2.Height)
                {
                    Matrix<T> m0 = new Matrix<T>(m1.Height, m2.Wigth);
                    for (int i = 0; i < m0.Height; i++)
                        for (int j = 0; j < m0.Wigth; j++)
                        {
                            dynamic c = 0;
                            for (int z = 0; z < m1.Wigth; z++)
                            {
                                dynamic a = m1.elem[i, z];
                                dynamic b = m2.elem[z, j];

                                c += (a * b);
                            }
                            m0.elem[i, j] = (T)c;
                        }
                    return m0;
                }
            return null;
        }
        public static Matrix<T> operator /(Matrix<T> m1, Matrix<T> m2)//нет!
        {
            if (m1.Height == m2.Wigth)
            {
                Matrix<T> m0 = new Matrix<T>(m1.Height, m2.Wigth);
                for (int i = 0; i < m0.Height; i++)
                    for (int j = 0; j < m0.Wigth; j++)
                    {
                        dynamic c = 0;
                        for (int z = 0; z < m1.Wigth; z++)
                        {
                            dynamic a = m1.elem[i, z];
                            dynamic b = m2.elem[z, j];

                            c += (a / b);
                        }
                        m0.elem[i, j] = (T)c;
                    }
                return m0;
            }
            return null;
        }
    }
    /*interface IMathCalculator<T>
    {
        T Add(T n1, T n2);
        T Sub(T n1, T n2);
        T Mul(T n1, T n2);
        T Div(T n1, T n2);
    }
    public class MatrixExeption : Exception
    {
        public MatrixExeption(string mes):base (mes)
        {

        }
    }*/

}
