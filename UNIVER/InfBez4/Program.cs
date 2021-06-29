using System;
using System.Collections;
using System.Numerics;
namespace InfBez1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4)
            //n = 517776452420107     e = 12377
            //ШТ = 50527945233429  232174902406749442926770512941299737185022728

            ulong N = 517776452420107, e = 12377;
            string C = "50527945233429 232174902406749442926770512941299737185022728";

            //ulong N = 565570077646207, e = 12341;
            //string C = "277140870674302260217431481485329310844916399448964498705119";

            int l = N.ToString().Length, w, l2;
            ArrayList list = new ArrayList();
            while (C != "")
            {
                
                if (C.Length > l)
                    l2 = l;
                else
                    l2 = C.Length;
                if ((Convert.ToUInt64(C.Substring(0, l2))) <= N)
                    w = l;
                else
                    w = l - 1;
                list.Add(C.Substring(0, l2));
                if (C.Length > l)
                    C = C.Substring(w);
                else
                    C = "";
            }//блоки по 15

            ulong t = (ulong)Math.Round(Math.Sqrt(N)), k = 0, d, p, q;
            while (true)
            {
                ulong y = (t + ++k) * (t + k) - N;
                if ((ulong)Math.Sqrt(y) * (ulong)Math.Sqrt(y) == y)
                {
                    p = t + k + (ulong)Math.Sqrt(y) - 1;
                    q = t + k - (ulong)Math.Sqrt(y) - 1;
                    k = 0;
                    break;
                };
            }//находим q и p перебором

            while (true)
                if ((1 + ++k * p * q) % e == 0)
                {
                    d = (1 + k * p * q) / e % (p * q);
                    break;
                }//вычислили ключ

            for (int i = 0; i < list.Count; i++)
                C += ((ulong)BigInteger.ModPow(Convert.ToUInt64(list[i]), d, N)).ToString();//c^d mod n
            list.Clear();//вынесли все из листа в С, в этот момент расшифровка, лист очистили

            while (C != "")
            {
                    l2 = 2;
                    list.Add(C.Substring(0, l2));
                    C = C.Substring(2);
            }//засунули расшифрованный текст из С в лист по блокам по 2 цифры

            for (int i = 0; i < list.Count; i++)
                C += (char)Convert.ToInt32(list[i]);//преобразуем в чары, заносим в С
            Console.WriteLine("P: " + (++p).ToString() + "; Q: " + (++q).ToString() + "\r\nd: " + d.ToString() + "\r\nMessage: " + C);
            Console.ReadKey();
        }
    }
}
