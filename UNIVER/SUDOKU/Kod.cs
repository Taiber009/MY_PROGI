using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SUDOKU
{
    class Kod
    {
        DataGridView[] field;
        public Kod(DataGridView[] f)
        {
            field = f;
        }
        public void SetValue(object value, int x, int y)//задать значение в ячейке, указать координаты x и y 0..8 и значение value 1..9
        {
            /*координаты поля, для наглядности
            Y
          X 0 1 2  3 4 5  6 7 8
            1 1 2  3 4 5  6 7 8
            2 2 2  3 4 5  6 7 8
            
            3 3 3  3 4 5  6 7 8
            4 4 4  4 4 5  6 7 8
            5 5 5  5 5 5  6 7 8
            
            6 6 6  6 6 6  6 7 8
            7 7 7  7 7 7  7 7 8
            8 8 8  8 8 8  8 8 8                
            */
            //DataGridView rightGrid = field[x % 3 + 3 * (y / 3)];
            field[(x / 3) + 3 * (y / 3)].Rows[y % 3].Cells[x % 3].Value = value;
        }
        public object GetValue(int x, int y)//получить значение в ячейке, указать координаты x и y 0..8
        {
            return field[(x / 3) + 3 * (y / 3)].Rows[y % 3].Cells[x % 3].Value;
        }

        public DataGridViewCell GetCell(int x, int y)//получить ссылку на ячейку, указать координаты x и y 0..8
        {
            return field[(x / 3) + 3 * (y / 3)].Rows[y % 3].Cells[x % 3];
        }
        //ПРОВЕРКИ!!!
        public bool GridCheck(DataGridView d)//проверка одного Grid, указывать сам Grid (или ссылку на него в массиве field)
        {
            bool[] check = new bool[9];
            object v;

            for (int i = 0; i < 9; i++)
            {
                v = d.Rows[i / 3].Cells[i % 3].Value;
                if (v != null)//(int)d.Rows[i / 3].Cells[i % 3].Value > 0 && (int)d.Rows[i / 3].Cells[i % 3].Value < 10)
                {// value ВСЕГДА должен быть в промежутке 1..9
                    if (!check[Convert.ToInt32(v) - 1])//массив check 0..8, а значение value 1..9
                        check[Convert.ToInt32(v) - 1] = true;
                    else
                        return false;
                }
            }
            return true;
        }
        /*public bool GridCheck(int d)//проверка одного Grid, указывать порядковый номер в field
        {
            bool[] check = new bool[9];
            object v;

            for (int i = 0; i < 9; i++)
            {
                v = field[d].Rows[i / 3].Cells[i % 3].Value;
                if (v != null)
                {// value ВСЕГДА должен быть в промежутке 1..9
                    if (!check[(int)v - 1])//массив check 0..8, а значение value 1..9
                        check[(int)v - 1] = true;
                    else
                        return false;
                }
            }
            return true;
        }*/
        public bool RowCheck(int r)//проверка по строке ВСЕГО поля, указывать строку 0..8
        {
            bool[] check = new bool[9];
            object v;
            for (int i = 0; i < 9; i++)
            {
                v = field[i / 3 + 3 * (r / 3)].Rows[r % 3].Cells[i % 3].Value;
                if (v != null)
                {// value ВСЕГДА должен быть в промежутке 1..9
                    if (!check[Convert.ToInt32(v) - 1])//массив check 0..8, а значение value 1..9
                        check[Convert.ToInt32(v) - 1] = true;
                    else
                        return false;
                }
            }
            return true;
        }
        public bool ColumnCheck(int c)//проверка по столбцу ВСЕГО поля, указывать столбец 0..8
        {
            bool[] check = new bool[9];
            object v;
            for (int i = 0; i < 9; i++)
            {
                v = field[c / 3 + 3 * (i / 3)].Rows[i % 3].Cells[c % 3].Value;
                if (v != null)
                {// value ВСЕГДА должен быть в промежутке 1..9
                    if (!check[Convert.ToInt32(v) - 1])//массив check 0..8, а значение value 1..9
                        check[Convert.ToInt32(v) - 1] = true;
                    else
                        return false;
                }
            }
            return true;
        }


        //можно еще перегрузок для проверок придумать
    }
}
