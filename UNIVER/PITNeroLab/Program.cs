using System;

namespace PITNeroLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Core().Result());
        }




        class Core
        {
            double[] w, v, err, w2, v2;
            string[] wtip, vtip, errtip, w2tip;
            public Core(/*string[] s*/)
            {
                w = new double[]{0.029,0.12,0.359,-0.006,-0.5,0.249,-0.066,
                -0.319,0.28,0.055,-0.07,0.8,0.114,0.096, 0.685 };//веса с рисунка 6
                wtip = new string[] { "w(1)-0(t+1)", "w(1)00(t+1)", "w(1)10(t+1)", "w(1)-1(t+1)", "w(1)01(t+1)", "w(1)11(t+1)", "w(2)-0(t+1)",
                 "w(2)00(t+1)", "w(2)10(t+1)", "w(2)-1(t+1)", "w(2)01(t+1)", "w(2)11(t+1)", "w(3)-0(t+1)", "w(3)00(t+1)","w(3)10(t+1)"};
                w2 = new double[15];
                w2tip = new string[] { "w(3)00(t+2)","w(3)10(t+2)","w(3)-0(t+2)","w(2)00(t+2)","w(2)10(t+2)","w(2)-0(t+2)","w(2)01(t+2)",
                "w(2)11(t+2)","w(2)-1(t+2)","w(1)00(t+2)","w(1)10(t+2)", "w(1)-0(t+2)","w(1)01(t+2)","w(1)11(t+2)","w(1)-1(t+2)"};
                v = new double[5];
                v2 = new double[5];
                vtip = new string[] { "f10", "f11", "f20", "f21", "f30", };
                err = new double[5];
                errtip = new string[] { "del(3)0", "del(2)0", "del(2)1", "del(1)0", "del(1)1" };
            }

            public string Result()
            {
                FindVals();
                FindErr();
                FindWeight();
                FindVals2();

                string s = "Веса:" + Environment.NewLine;
                for (int i = 0; i < w.Length; i++)
                    s += wtip[i] + " = " + w[i] + Environment.NewLine;

                s += Environment.NewLine + "Значения выходных сигналов:" + Environment.NewLine;
                for (int i = 0; i < v.Length; i++)
                    s += vtip[i] + " = " + v[i] + Environment.NewLine;

                s += Environment.NewLine + "Ошибка сети: " + (0.5 * Math.Pow(1 - v[v.Length - 1], 2)) + Environment.NewLine;
                s += Environment.NewLine + "Ошибки нейронов:" + Environment.NewLine;
                for (int i = 0; i < err.Length; i++)
                    s += errtip[i] + " = " + err[i] + Environment.NewLine;

                s += Environment.NewLine + "Новые значения весов:" + Environment.NewLine;
                for (int i = 0; i < w2.Length; i++)
                    s += w2tip[i] + " = " + w2[i] + Environment.NewLine;

                s += Environment.NewLine + "Новые значения выходных сигналов:" + Environment.NewLine;
                for (int i = 0; i < v2.Length; i++)
                    s += vtip[i] + " = " + v2[i] + Environment.NewLine;

                s += Environment.NewLine + "Новая ошибка сети: " + (0.5 * Math.Pow(1 - v2[v2.Length - 1], 2));
                return s;
            }
            void FindVals()
            {
                for (int i = 0; i < v.Length; i++)
                    if (i > 1)
                        v[i] = 1 / (1 + Math.Exp(-1 * (w[i * 3] * +w[i * 3 + 1] * v[(i / 2 - 1) * 2] + w[i * 3 + 2] * v[(i / 2 - 1) * 2 + 1])));//вес нейрона, левый вход, правый вход
                    else
                        v[i] = 1 / (1 + Math.Exp(-1 * (w[i * 3] + w[i * 3 + 1] + w[i * 3 + 2])));//слева и справа 1
            }

            public void FindErr()
            {
                err[0] = v[4] * (1 - v[4]) * (v[4] - 1);
                err[1] = v[2] * (1 - v[2]) * err[0] * w[13];
                err[2] = v[3] * (1 - v[3]) * err[0] * w[14];
                err[3] = v[0] * (1 - v[0]) * (err[1] * w[7] + err[2] * w[10]);
                err[4] = v[1] * (1 - v[1]) * (err[1] * w[8] + err[2] * w[11]);
            }
            void FindWeight()
            {
                w2[0] = w[13] - 0.8 * err[0] * v[2];
                w2[1] = w[14] - 0.8 * err[0] * v[3];
                w2[2] = w[12] - 0.8 * err[0] * 1;
                w2[3] = w[7] - 0.8 * err[1] * v[0];
                w2[4] = w[8] - 0.8 * err[1] * v[1];
                w2[5] = w[6] - 0.8 * err[1] * 1;
                w2[6] = w[10] - 0.8 * err[2] * v[0];
                w2[7] = w[11] - 0.8 * err[2] * v[1];
                w2[8] = w[9] - 0.8 * err[2] * 1;
                w2[9] = w[1] - 0.8 * err[3] * 1;
                w2[10] = w[2] - 0.8 * err[3] * 1;
                w2[11] = w[0] - 0.8 * err[3] * 1;
                w2[12] = w[4] - 0.8 * err[4] * 1;
                w2[13] = w[5] - 0.8 * err[4] * 1;
                w2[14] = w[3] - 0.8 * err[4] * 1;
            }
            void FindVals2()
            {
                v2[0] = 1 / (1 + Math.Exp(-1 * (w2[9] + w2[10] + w2[11])));
                v2[1] = 1 / (1 + Math.Exp(-1 * (w2[12] + w2[13] + w2[14])));
                v2[2] = 1 / (1 + Math.Exp(-1 * (w2[3] * v2[0] + w2[4] * v2[1] + w2[5])));
                v2[3] = 1 / (1 + Math.Exp(-1 * (w2[6] * v2[0] + w2[7] * v2[1] + w2[8])));
                v2[4] = 1 / (1 + Math.Exp(-1 * (w2[0] * v2[2] + w2[1] * v2[3] + w2[2])));
            }
        }
    }
}
