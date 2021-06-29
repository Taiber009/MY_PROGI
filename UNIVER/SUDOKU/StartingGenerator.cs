using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SUDOKU
{
    class StartingGenerator
    {
        /*public */
        Random rnd;//для рандома
        int rndMin, //минимальное число цифр в районе, определяется сложностью
            rndMax; //максимальное+1 (потому что последнее значение не выбирается рандомом)
        int[,] fieldGen;//сюда метод NewField() генерирует новое поле, а метод Generate() после него выбирает из него стартовые значения для игрока
        public StartingGenerator(int diff)
        {
            fieldGen = new int[9, 9];
            rnd = new Random();
            switch (diff)
            {
                case (1): //Легкая сложность - 3-5 начальных цифры в районе (numbs - параметры для функции Random.Next)
                    rndMin = 3;
                    rndMax = 6;
                    break;
                case (2)://Средняя сложность - 2-5 начальных цифры в районе
                    rndMin = 2;
                    rndMax = 6;
                    break;
                case (3)://Сложная сложность - 2-4 начальных цифры в районе
                    rndMin = 2;
                    rndMax = 5;
                    break;
                default: break;
            }
        }
        private void NewField()
        {//суть - генерируется поле судоку, откуда мы будем выбирать стартовые значения.
            //сначала генерируется поле 9х7, а последние 2 строке генерируются отдельно, потому что 
            //чем больше мы генерирует строк, тем больше вероятность попасть в ситуацию, когда мы для
            //ячейке не можем присвоить число 1-9, потому что все доступные цифры уже использованы по вертикали, горизонтали или в районе,
            //что говорит нам о непраильно сгенерированном поле.
            //первые 7 строк мы вполне можем сгенерировать через while, но в 8 строке есть только 1 правильный вариант из 512,  
            //поэтому там генерировать перебором слишком затратно
            //Пример:
            //123 456 789
            //459 713 26Х <-- сюда 8 вставить нельзя из-за района, но нужно для этой строки, ошибка
            //                
            //
            //
            //
            //
            //
            //
            int[,] last = new int[9, 2];//8 и 9 строки, сюда для каждых 9 столбцов выбираются возможные значения, которые не были использованы в 1-7 строках
            bool[,] check = new bool[9, 9];//отмечаем, какие цифры в столбце мы уже использовали (требуется для генерации 8 и 9 строк)
            StartingValue sv;//сюда генерирует цифру и проверяем ее на правильность для определенного квадрата.
            //если нет повтора, то записываем в fieldGen, если есть, то генерируем цифру заного
            bool b0 = true;
            while (b0)//генерируем поле 9х7 до тех пор, пока оно не сгенерируется правильно
            {
                bool b1 = true,
                     b2 = true;
                for (int i = 0; i < 7; i++)//7 строк
                {
                    for (int j = 0; j < 9; j++)//9 столбцов
                    {
                        sv = new StartingValue(rnd.Next(1, 10), j, i);//генерируем цифру (sv.val) для квадрата по координатам i строка (sv.y), j столбец (sv.x)
                        int d = 0; //20 раз пытаемся генерерировать число
                        while (!FullCheck(sv))//проверка сгенерированной цифры для ij-квадрата на повтор в строке, столбце и районе
                        {
                            sv.val = rnd.Next(1, 10);//если число не прошло проверку, оно генерируется заного
                            if (d++ > 20)//если прошло более 20 попыток, значит, поле сгенерировалось с ошибкой, и начинаем сначало
                            {
                                b2 = false;
                                for (int i2 = 0; i2 <= i; i2++)
                                {
                                    for (int j2 = 0; j2 < 9; j2++)
                                    {
                                        fieldGen[j2, i2] = 0;//очищаем все заполненные значения в поле...
                                    }
                                }
                                check = new bool[9, 9];
                                break;//... и начинаем сначала
                            }
                        }
                        if (!b2)
                        {
                            b1 = false;
                            break;//начинаем сначала
                        }
                        fieldGen[sv.x, sv.y] = sv.val;
                        check[j, sv.val - 1] = true;// отмечаем, что значение sv.val уже использовано для j-столбца  (sv.x)
                    }
                    if (!b1)
                        break;//начинаем сначала
                }
                if (b1&&b2)//если мы не прервали генерацию поля из-за ошибки и таким образом сгенерировли поле 9х7...
                    b0 = false;//.. то заканчиваем цикл while
            }

            for (int i = 0; i < 9; i++)//выбираем в массив last цифры (две на столбец) для каждого столбца, которые не были использованы в массиве check
            {
                int l = 0;
                for (int j = 0; j < 9; j++)
                {
                    if (!check[i, j])
                        last[i, l++] = j + 1;
                }

            }
            //итого мы знаем, какие 2 цифры в каждом столбце не были использованы, осталось только правильно их скомбинировать ДЛЯ 8 СТРОКИ,
            //чтобы не было повторов в строке и районе. 9 строка будет сгенерирована значениями, невошедшими в 8
            for (int i = 0; i < 511; i++)//2^9 всего возможных вариатов комбинаций
            {
                int[] a = ToBinary(i);//переводим номер нашей попытки в двоичное число, где будет 0 - выбираем верхнюю цифру в массиве last, а 1 - нижнюю
                bool b = true;// если комбинация для 8 строки была правильной
                for (int j = 0; j < 9; j++)
                {
                    sv = new StartingValue(last[j, a[j]], j, 7);
                    if (!FullCheck(sv))//если случился повтор (комбинация неверная)
                    {
                        for (int k = 0; k < j; k++)
                            fieldGen[k, 7] = 0;//стираем все вставленные в 8 строку значения и начинаем заного
                        b = false;//комбинация была неверной и...
                        break;//проверяем следующую
                    }
                    fieldGen[j, 7] = last[j, a[j]];
                }
                if (b)//если 8 строка была успешно подобрана, если нет, то игнорируем
                {
                    a = Invert(ref a);//инвертируем 
                    for (int j = 0; j < 9; j++)
                    {
                        fieldGen[j, 8] = last[j, a[j]];//заполняем 9 строку
                    }
                    break;
                }
            }

        }

        private int[] ToBinary(int v)//перевод 10ричного числа в 2ичное
        {
            int[] a = new int[9];
            for (int i = 0; i < 9; i++)
            {
                a[i] = v % 2;
                v /= 2;
            }
            return a;
        }
        private int[] Invert(ref int[] a)//инверируем 2ичное число
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == 0)
                    a[i] = 1;
                else
                    a[i] = 0;
            return a;
        }
        public Queue<StartingValue> Generate() //генерирует поле по правилам судоку (NewField()), выбираем из него стартовые значения для игрока и
        //передаем их в виде очереди стуктур StartingValue
        {
            StartingValue[] svs;
            Queue<StartingValue> qsv = new Queue<StartingValue>();
            int rx = 0, ry = 0;

            NewField();

            for (int i = 0; i < 9; i++)//идем по всем районам
            {
                int numbs = rnd.Next(rndMin, rndMax);//количество стартовых значения для каждого района
                svs = new StartingValue[numbs];
                for (int j = 0; j < numbs; j++)//весь этот цикл нужен, чтобы после генерации координат rx И ry проверить на повтор
                {
                    bool check = false;
                    while (!check)//генерируем координаты стартовых значений в количестве numbs для каждого i-района
                    {
                        bool check2 = true;
                        rx = rnd.Next(i * 3 % 9, i * 3 % 9 + 3);//координаты стартовых значений
                        ry = rnd.Next(i / 3 * 3, i / 3 * 3 + 3);//от номера района зависят допустимые координаты x и y (0-2, 3-5 или 6-8) 

                        for (int k = 0; k < j; k++)//проверка с уже сгенерированными координатами х,y на пару совпадающих, при рандоме такое может быть
                            if (rx == svs[k].x && ry == svs[k].y)//если есть 2 совпадающих пары x,y...
                            {
                                check2 = false;//...то циклом while генерируем заного
                            }
                        if (check2)
                            check = true;//иначе заканчиваем цикл
                    }
                    svs[j] = new StartingValue(fieldGen[rx, ry], rx, ry);//после генерации координат формируем стартовое число...
                }

                for (int j = 0; j < numbs; j++)//... и вносим все, что сгенерировали в очередь
                    qsv.Enqueue(svs[j]);
            }


            return qsv;//возвращаем все сгенерированные стартовые значения в виде очереди
        }

        /*public bool NoDeadLockCheck(int x, int y)//проверка по строке, столбцу и квадрату, что в ячейку по коорд. x,y можно 
        {
            bool[] vals = new bool[10];
            vals[0] = true;
            for (int i = 0; i < x; i++)
            {
                if (fieldGen[i, y] != 0)
                    vals[fieldGen[i, y]] = true;
            }
            for (int i = x; i < 9; i++)
            {
                if (fieldGen[i, y] != 0)
                    vals[fieldGen[i, y]] = true;
            }
            for (int i = 0; i < y; i++)
            {
                if (fieldGen[x, i] != 0)
                    vals[fieldGen[i, y]] = true;
            }
            for (int i = y; i < 9; i++)
            {
                if (fieldGen[x, i] != 0)
                    vals[fieldGen[i, y]] = true;
            }

            return true;
        }*/
        public bool AreaCheck(StartingValue sv)//проверка одного района
        {
            for (int i = sv.y / 3 * 3; i < sv.y / 3 * 3 + 3; i++)
            {
                for (int j = sv.x / 3 * 3; j < sv.x / 3 * 3 + 3; j++)
                {
                    if (fieldGen[j, i] == sv.val)
                    {
                        return false;
                    }
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
        public bool RowCheck(StartingValue sv)//проверка по строке
        {
            for (int j = 0; j < 9; j++)
            {
                if (fieldGen[j, sv.y] == sv.val)
                {
                    return false;
                }
            }
            return true;
        }
        public bool ColumnCheck(StartingValue sv)//проверка по столбцу
        {
            for (int i = 0; i < 9; i++)
            {
                if (fieldGen[sv.x, i] == sv.val)
                {
                    return false;
                }
            }
            return true;
        }

        public bool FullCheck(StartingValue sv)//проверка по строке, столбцу и району
        {
            return (AreaCheck(sv) && RowCheck(sv) && ColumnCheck(sv)) ? true : false;

        }

    }
}

