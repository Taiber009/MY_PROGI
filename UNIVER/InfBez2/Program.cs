using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//8 вариант

namespace InfBez1
{
    class Program
    {
        static uint RSdvig(uint value, int sdvig)
        {
            return value << (32 - sdvig % 32) | value >> sdvig % 32;
        }

        static ulong RSdvig(ulong value, int sdvig)
        {
            return value << (64 - sdvig % 64) | value >> sdvig % 64;
        }

        static uint LSdvig(uint value, int sdvig)
        {
            return value >> (32 - sdvig % 32) | value << sdvig % 32;
        }

        static ulong LSdvig(ulong value, int sdvig)
        {
            return value >> (64 - sdvig % 64) | value << sdvig % 64;
        }

        public static void Swap(ref uint x, ref uint y)
        {
            uint z = x;
            x = y;
            y = z;
        }
        public static uint F(uint Li, uint Ki)
        {
            uint Li9 = LSdvig(Li, 9);
            return Li9 ^ (~(RSdvig(Ki, 11) ^ Li9));//////
        }

        public static uint[] SplitUlong(ulong value)
        {
            uint[] arr = new uint[2];
            arr[0] = (uint)((value & ((ulong)uint.MaxValue << 32)) >> 32);
            arr[1] = (uint)(value & uint.MaxValue);
            return arr;
        }

        public static uint CreateRoundKey(ulong K, int i)
        {
            uint[] arr = SplitUlong(RSdvig(K, i * 8));
            return arr[1];
        }
        
        static void Main(string[] args)
        {
            ulong K = ulong.Parse(Console.ReadLine());
           
            Console.WriteLine("Vvedite kolichestvo znacheniy");
            int length = Int32.Parse(Console.ReadLine());
            if (length % 2 != 0)
                throw new ArgumentException("Razmer znacheniy dolzen bit' kraten 2!");
            uint[] x = new uint[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Vvedite znacheniy " + i);
                x[i] = UInt32.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Vvedite kolichestvo raundov (ot 2 do 12)");
            int n = int.Parse(Console.ReadLine());
            if (n < 2 || n > 12)
                throw new ArgumentException("Kolichestvo raundov dolzno bit' ot 2 do 12!");

            for (int s = 0; s < x.Length; )
            {
                uint L = x[s++];
                uint R = x[s++];
                Console.WriteLine("Start...");
                Console.WriteLine("L = " + L);
                Console.WriteLine("R = " + R);
                Console.WriteLine("");
                for (int i = 0; i < n; i++)
                {
                    if (i != 0)
                        Swap(ref L, ref R);
                    uint Ki = CreateRoundKey(K,i);
                    R = F(L, Ki) ^ R;

                    Console.WriteLine("Preobrazovanie pri i = " + i);
                    Console.WriteLine("L = " + L);
                    Console.WriteLine("R = " + R);
                    Console.WriteLine("");
                }
                
                Console.WriteLine("===========");
                Console.WriteLine("Decrypt...");

                for (int i = n - 1; i >= 0; i--)
                {

                    if (i != n-1)
                        Swap(ref L, ref R);
                    uint Ki = CreateRoundKey(K, i);
                    R = F(L, Ki) ^ R;

                    Console.WriteLine("Preobrazovanie pri i = " + i);
                    Console.WriteLine("L = " + L);
                    Console.WriteLine("R = " + R);
                    Console.WriteLine("");
                }

                Console.WriteLine("_________________");
            }
            Console.ReadKey();
        }
    }
}
