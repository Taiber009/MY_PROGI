using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Anagramer
{
    class Program
    {
        class num
        {
            num _next;
            public int _val;
            int _len;

            public num(int length)
            {
                _val = 0;
                _len = length;
                //_next = null; //???
            }
            public num(int length, num next)
            {
                _val = 0;
                _len = length;
                _next = next;
            }
            public void Plus()
            {
                if (_val == _len - 1)
                {
                    _val = 0;
                    //if (_next != null)
                    _next.Plus();
                }
                else
                    _val++;
            }

            /*public string ToStrng()
            {
                if (_next != null)
                    return _next.ToStrng() + _val;
                else
                    return "" + _val;
            }*/
        }

        static int[] Parse(num[] n)
        {
            int[] arr = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
                arr[i] = n[i]._val;
            return arr;
        }

        static bool Check(int[] arr)
        {
            bool[] b = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (b[arr[i]])
                    return false;
                b[arr[i]] = true;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Write some words without spaces and capital letters: ");
            String s = Console.ReadLine(), s1 = "", path = @"Anagrams.txt";
            Console.WriteLine();
            //Console.WriteLine("Anagrams: ");
            FileStream fs;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            fs = File.Create(path);
            //fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None);
            //  File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None);
            //fs = File.Create(path);



            int win = 0;
            double perc = 0.01;
            int[] array;

            num[] nums = new num[s.Length];
            nums[0] = new num(s.Length);
            for (int i = 1; i < s.Length; i++)
            {
                nums[i] = new num(s.Length, nums[i - 1]);
            }

            double max = Math.Pow(s.Length, s.Length);
            for (double i = 0; i < max - 1; i++)
            {
                nums[s.Length - 1].Plus();
                array = Parse(nums);
                if (Check(array))
                {
                    for (int j = 0; j < s.Length; j++)
                        s1 += s[array[j]];

                    //File.WriteAllText(path, s1+Environment.NewLine);

                    Byte[] info =
                        new UTF8Encoding(true).GetBytes(s1 + Environment.NewLine);

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);

                    //Console.WriteLine(s1);
                    //Console.WriteLine("Complited at... "+Math.Round((i/max),4)*100+" %");
                    win++;
                    s1 = "";
                }

                if (i / max >= perc)
                {
                    Console.WriteLine("Found... " + Math.Round(perc, 2) * 100 + " % words");
                    perc += 0.01;
                }
            }

            Console.WriteLine("There are only " + win + " words. They were written to file " + '"' + "Anagrams.txt" + '"');
            fs.Close();
            Console.ReadKey();
        }
    }
}
