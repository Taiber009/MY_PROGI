using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXAMPLE2010
{
    class Kod
    {
        /*
         
        public double w;       //0 выделяемая полоса
        public double w2;      //1 занимаемая полоса
        public double St;      //2 мощность сигнала
        public double A;       //3 ослабление сигнала
        public double L;       //4 затухания на линии
        public double T;       //5 температура в К
        public double EbNo;    //6 отношение сигнал/шум
        public double spec;    //7 спектральная эффективность
        public double SNo;     //8 бюджет можности
        public double rb;      //9 скорость
        public double rmax;    //10 предельная скорость
        public double specmax; //11 предельная спектральная эффективность
         */
        public const double bol = -228.6;

        public Kod()
        {
        }

        public double[] Solve(ref double[] x)
        {
            for (int i = 0; i < 5; i++)
            {
                if (x[8] == 0 && x[2] != 0 && x[3] != 0 && x[4] != 0 && x[5] != 0)
                    x[8] = Math.Round(x[2] - x[3] - x[4] - lin2db(x[5]) - bol, 2);

                else if (x[8] != 0 && x[2] == 0 && x[3] != 0 && x[4] != 0 && x[5] != 0)
                    x[2] = Math.Round(x[8] + x[3] + x[4] + lin2db(x[5]) + bol, 2);

                else if (x[8] != 0 && x[2] != 0 && x[3] == 0 && x[4] != 0 && x[5] != 0)
                    x[3] = Math.Round(x[2] - x[8] - x[4] - lin2db(x[5]) - bol, 2);

                else if (x[8] != 0 && x[2] != 0 && x[3] != 0 && x[4] == 0 && x[5] != 0)
                    x[4] = Math.Round(x[2] - x[3] - x[8] - lin2db(x[5]) - bol, 2);

                else if (x[8] != 0 && x[2] != 0 && x[3] != 0 && x[4] != 0 && x[5] == 0)
                    x[5] = Math.Round(db2lin(x[2] - x[3] - x[4] - x[8] - bol), 2);


                if (x[9] == 0 && x[8] != 0 && x[6] != 0)
                    x[9] = Math.Round(db2lin(x[8] - x[6]), 2);

                else if (x[9] != 0 && x[8] == 0 && x[6] != 0)
                    x[8] = Math.Round(lin2db(x[9]) + x[6], 2);

                else if (x[9] != 0 && x[8] != 0 && x[6] == 0)
                    x[6] = Math.Round(x[8] - lin2db(x[9]), 2);


                if (x[1] == 0 && x[9] != 0 && x[7] != 0)
                    x[1] = Math.Round(x[9] / x[7], 2);

                else if (x[1] != 0 && x[9] == 0 && x[7] != 0)
                    x[9] = Math.Round(x[1] * x[7], 2);

                else if (x[1] != 0 && x[9] != 0 && x[7] == 0)
                    x[7] = Math.Round(x[9] / x[1], 2);


                if (x[11] == 0 && x[8] != 0 && x[0] != 0)
                    x[11] = Math.Round(Math.Log(db2lin(x[8]) / x[0] + 1, 2), 2);

                else if (x[11] != 0 && x[8] == 0 && x[0] != 0)
                    x[8] = Math.Round(lin2db((Math.Pow(2, x[11]) - 1) * x[0]), 2);

                else if (x[11] != 0 && x[8] != 0 && x[0] == 0)
                    x[0] = Math.Round(db2lin(x[8]) / (Math.Pow(2, x[11]) - 1), 2);


                if (x[10] == 0 && x[0] != 0 && x[11] != 0)
                    x[10] = Math.Round(x[0] * x[11], 2);

                else if (x[10] != 0 && x[0] == 0 && x[11] != 0)
                    x[0] = Math.Round(x[10] / x[11], 2);

                else if (x[10] != 0 && x[0] != 0 && x[11] == 0)
                    x[11] = Math.Round(x[10] / x[0], 2);

                if (x[0] != 0 && x[1] != 0 && x[2] != 0 && x[3] != 0 && 
                    x[6] != 0 && x[7] != 0 && x[8] != 0 && x[9] != 0 && 
                    x[10] != 0 && x[11] != 0) break;
            }
            return x;
        }

        public double lin2db(double x)
        {
            return 10 * Math.Log10(x);
        }

        public double db2lin(double x)
        {
            return Math.Pow(10, (x / 10));
        }

    }
}
