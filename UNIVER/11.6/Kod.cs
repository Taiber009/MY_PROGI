using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._6
{
    class Kod
    {
        public static int go(int d, int m, int y)
        {
            int win = 0, d1 = 1, m1 = 1, y1 = 1, wd = 1;

            if (y1 < y)
            {
                for (y1 = 1; y1 <= y; y1++)
                {
                    for (m1 = 1; m1 <= 12; m1++)
                    {
                        if ((m1 == 1) || (m1 == 3) || (m1 == 5) || (m1 == 7) || (m1 == 8) || (m1 == 10) || (m1 == 12))
                        {
                            for (d1 = 1; d1 <= 31; d1++)
                            {
                                if ((wd == 5) && (d1 == 13))
                                {
                                    win++;
                                }
                                if (wd < 7) wd++;
                                else wd = 1;
                            }
                        }
                        if ((m1 == 4) || (m1 == 6) || (m1 == 9) || (m1 == 11))
                        {
                            for (d1 = 1; d1 <= 30; d1++)
                            {
                                if ((wd == 5) && (d1 == 13))
                                {
                                    win++;
                                }
                                if (wd < 7) wd++;
                                else wd = 1;
                            }
                        }
                        if (m1 == 2)
                        {
                            if ((y1 % 4 == 0))
                            {
                                for (d1 = 1; d1 <= 29; d1++)
                                {
                                    if ((wd == 5) && (d1 == 13))
                                    {
                                        win++;
                                    }
                                    if (wd < 7) wd++;
                                    else wd = 1;
                                }
                            }
                            else
                            {
                                for (d1 = 1; d1 <= 28; d1++)
                                {
                                    if ((wd == 5) && (d1 == 13))
                                    {
                                        win++;
                                    }
                                    if (wd < 7) wd++;
                                    else wd = 1;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (m1 = 1; m1 <= m; m1++)
                {
                    if (m1 < m)
                    {
                        if ((m1 == 1) || (m1 == 3) || (m1 == 5) || (m1 == 7) || (m1 == 8) || (m1 == 10) || (m1 == 12))
                        {
                            for (d1 = 1; d1 <= 31; d1++)
                            {
                                if ((wd == 5) && (d1 == 13))
                                {
                                    win++;
                                }
                                if (wd < 7) wd++;
                                else wd = 1;
                            }
                        }
                        if ((m1 == 4) || (m1 == 6) || (m1 == 9) || (m1 == 11))
                        {
                            for (d1 = 1; d1 <= 30; d1++)
                            {
                                if ((wd == 5) && (d1 == 13))
                                {
                                    win++;
                                }
                                if (wd < 7) wd++;
                                else wd = 1;
                            }
                        }
                        if (m1 == 2)
                        {
                            if ((y1 % 4 == 0))
                            {
                                for (d1 = 1; d1 <= 29; d1++)
                                {
                                    if ((wd == 5) && (d1 == 13))
                                    {
                                        win++;
                                    }
                                    if (wd < 7) wd++;
                                    else wd = 1;
                                }
                            }
                            else
                            {
                                for (d1 = 1; d1 <= 28; d1++)
                                {
                                    if ((wd == 5) && (d1 == 13))
                                    {
                                        win++;
                                    }
                                    if (wd < 7) wd++;
                                    else wd = 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (d1 = 1; d1 <= d; d1++)
                        {
                            if ((wd == 5) && (d1 == 13))
                            {
                                win++;
                            }
                            if (wd < 7) wd++;
                            else wd = 1;
                        }
                    }
                }
            }
            return win;
        }
    }
}