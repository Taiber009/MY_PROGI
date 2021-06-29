using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Сапер_1_
{

    internal class Kod
    {
        public Kod(int a)
        {
            Lenght1 = a;
            newPole();
            Generate();
            Numbers();
        }
        private int[,] Pole;
        public int[,] PoleSafe;
        private bool[,] PoleRecurs;
        private Random rand = new Random();
        private int Lenght1;
        public int Lenght()
        {
            return Lenght1;
        }
        public int PoleGet(int x, int y)
        {
            return Pole[x, y];
        }

        private void newPole()
        {
            Pole = new int[Lenght1 + 2, Lenght1 + 2];
            PoleSafe = new int[Lenght1, Lenght1];
        }
        private void Generate()
        {
            for (int i = 0; i < Lenght1 + 2; i++)
            {
                for (int j = 0; j < Lenght1 + 2; j++)
                {
                    if ((i > 0) && (i < Lenght1 + 1) && (j > 0) && (j < Lenght1 + 1))
                        Pole[i, j] = rand.Next(0, 7);
                    else
                        Pole[i, j] = -1;

                }
            }
        }
        private void Numbers()
        {
            for (int i = 0; i < Lenght(); i++)
            {
                for (int j = 0; j < Lenght(); j++)
                {
                    if (Pole[i + 1, j + 1] != 0)
                    {
                        int x = 0;
                        for (int i2 = -1; i2 <= 1; i2++)
                        {
                            for (int j2 = -1; j2 <= 1; j2++)
                            {
                                if (Pole[i + i2 + 1, j + j2 + 1] == 0)
                                    x++;
                            }
                        }
                        if (x != 0)
                            Pole[i + 1, j + 1] = x;
                        else
                            Pole[i + 1, j + 1] = 10;
                    }
                }
            }
        }
        
        public Stack<int[]> MyStack;
        public int CoordsNubmers;
        public void RecursStart(int x, int y)
        {
            PoleRecurs = new bool[Lenght1, Lenght1];
            MyStack = new Stack<int[]>();
            CoordsNubmers = 0;
            for (int i = 0; i < Lenght1; i++)
            {
                for (int j = 0; j < Lenght1; j++)
                {
                    PoleRecurs[i, j] = true;
                }
            }
            Recurs(x, y);
        }
        private void Recurs(int x, int y)
        {
            for (int i2 = -1; i2 <= 1; i2++)
            {
                for (int j2 = -1; j2 <= 1; j2++)
                {
                    if ((Pole[x + j2 + 1, y + i2 + 1] != -1) && (PoleRecurs[x + j2, y + i2] == true))
                    {
                        int[] Coords = new int[] { x + j2, y + i2 };
                        MyStack.Push(Coords);
                        CoordsNubmers++;
                        PoleRecurs[x + j2, y + i2] = false;
                        if (Pole[x + j2 + 1, y + i2 + 1] == 10)
                            Recurs(x + j2, y + i2);
                    }
                }
            }
        }

    }

}
