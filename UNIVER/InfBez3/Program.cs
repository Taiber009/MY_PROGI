using System;

//8 вариант
//CBC (Cipher Block Chaining) и CFB (Cipher Feedback)
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

        public static uint SplitUlong(ulong value, bool rightPart)
        {
            uint[] arr = new uint[2];
            if (!rightPart)
                return (uint)((value & ((ulong)uint.MaxValue << 32)) >> 32);
            else
                return (uint)(value & uint.MaxValue);
        }

        public static uint CreateRoundKey(ulong K, int i)
        {
            uint[] arr = SplitUlong(RSdvig(K, i * 8));
            return arr[1];
        }

        public static uint CreateRoundKey(uint K, int i)
        {
            return RSdvig(K, i * 8);
        }

        public static uint[] CreateBlocks(string text)
        {
            uint[] blocks = new uint[text.Length / 2];
            for (int i = 0; i < text.Length / 2; i++)
            {
                blocks[i] += text[i * 2];
                blocks[i] <<= 16;
                blocks[i] += text[i * 2 + 1];
            }
            return blocks;
        }

        public static string CreateText(uint[] blocks)
        {
            string text = ""; //= new char[blocks.Length * 2];
            for (int i = 0; i < blocks.Length; i++)
            {
                text += (char)(ushort)((blocks[i] & ((uint)ushort.MaxValue << 16)) >> 16);
                text += (char)(ushort)(blocks[i] & ushort.MaxValue);
            }
            return text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite klych (ot 0 do 18.446.744.073.709.551.615):");
            ulong K = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Vvedite vector initcializacii (ot 0 do 18.446.744.073.709.551.615):");
            ulong V = ulong.Parse(Console.ReadLine());
            uint V1 = SplitUlong(V, false); uint V2 = SplitUlong(V, true);


            Console.WriteLine("Vvedite text:");
            string text = Console.ReadLine();
            if (text.Length % 4 != 0)
            {
                int l = text.Length;
                for (int i = 0; i < 4 - l % 4; i++)
                    text += ' ';
            }
            uint[] x = CreateBlocks(text);
            uint[] y = new uint[x.Length];
            uint[] z = new uint[x.Length];
            /*Console.WriteLine("Vvedite kolichestvo znacheniy (kratnoe 2)");
            int length = Int32.Parse(Console.ReadLine());
            if (length % 2 != 0)
                throw new ArgumentException("Razmer znacheniy dolzen bit' kraten 2!");
            

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Vvedite znachenie " + (i + 1) + " (ot 0 do 4.294.967.295)");
                x[i] = UInt32.Parse(Console.ReadLine());
            }*/

            Console.WriteLine("Vvedite kolichestvo raundov (ot 2 do 12):");
            int n = int.Parse(Console.ReadLine());
            if (n < 2 || n > 12)
                throw new ArgumentException("Kolichestvo raundov dolzno bit' ot 2 do 12!");

            char vibor;
            bool type = true;
            while (true)
            {
                Console.WriteLine("Kakoi tip shifrovaniya? (CBC = 1, CFB = 2):");
                vibor = Console.ReadLine()[0];
                if (vibor == '1')
                    break;
                if (vibor == '2')
                {
                    type = false;
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (type)//CBC (Cipher Block Chaining)
            {
                Console.WriteLine("Vibrano: CBC (Cipher Block Chaining)");
                //encrypt
                for (int s = 0; s < x.Length; s = s + 2)
                {
                    uint L = x[s];
                    uint R = x[s + 1];
                    if (s == 0)
                    {
                        L = L ^ V1;
                        R = R ^ V2;
                    }
                    else
                    {
                        L = L ^ y[s - 2];
                        R = R ^ y[s - 1];
                    }
                    for (int i = 0; i < n; i++)
                    {
                        if (i != 0)
                            Swap(ref L, ref R);
                        uint Ki = CreateRoundKey(K, i);
                        R = F(L, Ki) ^ R;
                    }
                    y[s] = L;
                    y[s + 1] = R;
                }
                //decrypt
                for (int s = y.Length - 2; s >= 0; s = s - 2)
                {
                    uint L = y[s];
                    uint R = y[s + 1];
                    for (int i = n - 1; i >= 0; i--)
                    {
                        if (i != n - 1)
                            Swap(ref L, ref R);
                        uint Ki = CreateRoundKey(K, i);
                        R = F(L, Ki) ^ R;
                    }
                    if (s != 0)
                    {
                        z[s] = L ^ y[s - 2];
                        z[s + 1] = R ^ y[s - 1];
                    }
                    else
                    {
                        z[s] = L ^ V1;
                        z[s + 1] = R ^ V2;
                    }
                }
            }
            else//CFB (Cipher Feedback)
            {
                Console.WriteLine("Vibrano: CFB (Cipher Feedback)");
                //encrypt
                for (int s = 0; s < x.Length; s = s + 2)
                {
                    uint L;
                    uint R;
                    if (s == 0)
                    {
                        L = V1;
                        R = V2;
                    }
                    else
                    {
                        L = y[s - 2];
                        R = y[s - 1];
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if (i != 0)
                            Swap(ref L, ref R);
                        uint Ki = CreateRoundKey(K, i);
                        R = F(L, Ki) ^ R;
                    }


                    y[s] = L ^ x[s];
                    y[s + 1] = R ^ x[s + 1];
                }
                //decrypt
                for (int s = 0; s < y.Length; s = s + 2)
                {
                    uint L;
                    uint R;

                    if (s == 0)
                    {
                        L = V1;
                        R = V2;
                    }
                    else
                    {
                        L = y[s - 2];
                        R = y[s - 1];
                    }

                    for (int i = n - 1; i >= 0; i--)
                    {
                        if (i != n - 1)
                            Swap(ref L, ref R);
                        uint Ki = CreateRoundKey(K, i);
                        R = F(L, Ki) ^ R;
                    }

                    z[s] = L ^ y[s];
                    z[s + 1] = R ^ y[s + 1];
                }
            }

            string decrtext = CreateText(z);
            int j=0;
            for (int i = decrtext.Length - 1; decrtext[i] == ' '; i--)
            {
                j++;
            }
            if (j>0)
               decrtext=decrtext.Remove(decrtext.Length - j);



            Console.WriteLine("Ishodniy text: " + text);
            Console.WriteLine();
            Console.WriteLine("____________________________________________");
            Console.WriteLine("  i|blocks|  Ishodnie|   Encrypt|   Decrypt|");
            Console.WriteLine("____________________________________________");
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine("{0,3}|{1,6}|{2,10}|{3,10}|{4,10}|", (i + 1), ("" + text[i * 2] + text[i * 2 + 1]), x[i], y[i], z[i]);
            Console.WriteLine("____________________________________________");
            Console.WriteLine();
            Console.WriteLine("Deshifrovanniy text: " + CreateText(z));
            Console.ReadKey();
        }
    }
}
