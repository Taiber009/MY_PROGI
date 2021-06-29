using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace SUDOKU
{
    public partial class SudokuForm : Form
    {
        //экземпляры

        public DataGridView[] field;
        StartingValue[] startVals;//массив структур, описывающих начальные значения (координаты и само значение)
        SoundPlayer sp;//для музыки
        Kod kod;
        MyTimer mytimer;
        ////////////////////////////////////////////////////////
        //методы

        public SudokuForm()
        {
            InitializeComponent();
            field = new DataGridView[] { Grid1, Grid2, Grid3, Grid4, Grid5, Grid6, Grid7, Grid8, Grid9 };//представление 9 datagridview как одного поля + проще обращаться к каждому
            kod = new Kod(field);//класс со "сложными" методами
            sp = new SoundPlayer(Application.StartupPath + @"\Media\1.wav");//путь до файла с музыкой
            mytimer = new MyTimer();
            StartProg();

        }



        private void StartProg()//старт программы
        {
            for (int i = 0; i < 9; i++)
            {
                field[i].RowCount = 3;
                field[i].ColumnCount = 3;

                field[i].Rows[0].Cells[0].Selected = true;
                field[i].Rows[0].Cells[0].Selected = false;//для красоты

                field[i].Enabled = false;
            }
        }

        private void StartNewGame(int v)//начала НОВОЙ игры (c генерацией поля)
        {
            Queue<StartingValue> qsv = new StartingGenerator(v).Generate();
            startVals = new StartingValue[qsv.Count];
            int c = qsv.Count;
            for (int i = 0; i < c; i++)
                startVals[i] = qsv.Dequeue();
            SetStartingValues();//выставляет и блокирует начальные значения
            StartGame();//начало игры
        }

        private void StartGame()//начало игры
        {
            for (int i = 0; i < 9; i++)
                field[i].Enabled = true;

            BNewgame.Visible = false;
            BSave.Visible = true;
            BEnd.Visible = true;
            LDiff.Visible = true;

            LTimer.Visible = true;
            Timer.Enabled = true;
        }

        private void SetStartingValues()//блокировка редактированя начальных значений
        {
            for (int i = 0; i < startVals.Length; i++)
            {
                kod.SetValue(startVals[i].val, startVals[i].x, startVals[i].y);
                kod.GetCell(startVals[i].x, startVals[i].y).ReadOnly = true;
            }
        }

        private void EndGameCheck()//условия завершения игры
        {
            if (FilledFieldCheck())//если поле полностью заполнено
                if (CorrectFieldCheck())//если поле заполнено правильно
                {//победа
                    Timer.Enabled = false;
                    sp.PlayLooping();//музыка!
                    MessageBox.Show("Поздравляем! Вы завершили игру Судоку за время " + LTimer.Text + " на уровне сложности " + LDiff.Text + '!');
                    sp.Stop();

                    EndGame();//очистка поля
                }
        }

        private bool FilledFieldCheck()//если поле полностью заполнено
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (kod.GetValue(j, i) == null)
                        return false;
                }
            }
            return true;
        }

        private bool CorrectFieldCheck()//если поле заполнено правильно
        {
            for (int i = 0; i < 9; i++)
            {
                if (!kod.GridCheck(field[i]))//проверка по полям
                {
                    MessageBox.Show("Одинаковые символы в " + FieldName(i) + " районе!");
                    return false;
                }
                if (!kod.RowCheck(i))//проверка по строкам
                {
                    MessageBox.Show("Одинаковые символы в " + i + " строке!");
                    return false;
                }
                if (!kod.ColumnCheck(i))//проверка по столбцам
                {
                    MessageBox.Show("Одинаковые символы в " + i + " колонке!");
                    return false;
                }
            }
            return true;
        }

        private string FieldName(int x)//см. CorrectFieldCheck
        {
            string s;
            if (x == 4)
                return "центральном ";

            if (x % 3 == 0)
                s = "левом ";
            else if (x % 3 == 2)
                s = "правом ";
            else s = "среднем ";

            if (x < 3)
                s += "верхнем ";
            else if (x > 5)
                s += "нижнем ";
            else s += "среднем ";

            return s;
        }

        private void EndGame()//очистка поля
        {
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    kod.SetValue(null, i, j);
                }
            }

            for (int i = 0; i < startVals.Length; i++)
            {
                kod.GetCell(startVals[i].x, startVals[i].y).ReadOnly = false;
            }
            startVals = null;

            Timer.Enabled = false;
            LTimer.Text = "0:0";
            LTimer.Visible = false;
            LDiff.Visible = false;
            mytimer.time = 0;

            LDiff.Text = "";

            BEnd.Visible = false;
            BSave.Visible = false;
            BNewgame.Visible = true;
        }
        ////////////////////////////////////////////////////////
        //дефолтные события

        private void BNewgame_Click(object sender, EventArgs e)//кнопка Новая игра
        {
            DifficultyForm form = new DifficultyForm();
            form.ShowDialog();
            int diff = form.diff;
            switch (diff)
            {
                case (1):
                    //Начать игру на сложности Простая, 3-5 начальных цифры в одном квадрате

                    LDiff.Text = "Простая";
                    StartNewGame(diff);//начала НОВОЙ игры (c генерацией поля)
                    break;
                case (2):
                    //Начать игру на сложности Средняя, 3-4 начальных цифры в одном квадрате

                    LDiff.Text = "Средняя";
                    StartNewGame(diff);
                    break;
                case (3):
                    //Начать игру на сложности Сложная, 2-4 начальных цифры в одном квадрате

                    LDiff.Text = "Сложная";
                    StartNewGame(diff);
                    break;
                default: break;
            }
        }

        private void BSave_Click(object sender, EventArgs e)//кнопка Сохранить игру
        {
            Timer.Enabled = false;

            //SFD.InitialDirectory = Application.StartupPath + @"\Saves";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                string save = "";

                for (int i = 0; i < startVals.Length; i++)
                {
                    save += startVals[i].val;
                    save += startVals[i].x;
                    save += startVals[i].y;
                }

                save += '!' + Convert.ToString(mytimer.time) + '!' + LDiff.Text + '!'; ;

                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++)
                        save += Convert.ToInt32(kod.GetValue(j, i));

                File.WriteAllText(@SFD.FileName, save);
                MessageBox.Show("Игра сохранена в файл \"" + SFD.FileName + "\"!");
            }
            OFD.FileName = "";

            Timer.Enabled = true;
        }

        private void BLoad_Click(object sender, EventArgs e)//кнопка Загрузить игру
        {
            Timer.Enabled = false;

            //OFD.InitialDirectory = Application.StartupPath + @"\Saves";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string s = "", load = File.ReadAllText(@OFD.FileName);
                int j = 0;

                MessageBox.Show("Был загружен файл " + '"' + OFD.SafeFileName + '"');

                for (int i = j; load[i] != '!' && i < load.Length - 1; i++)
                {
                    s += load[i];

                }
                startVals = new StartingValue[s.Length / 3];

                for (int i = j; load[j] != '!' && i < load.Length - 1; i = i + 3)
                {
                    startVals[i / 3].val = Int32.Parse("" + s[j++]);
                    startVals[i / 3].x = Int32.Parse("" + s[j++]);
                    startVals[i / 3].y = Int32.Parse("" + s[j++]);
                }
                s = "";

                for (int i = ++j; load[i] != '!' && i < load.Length - 1; i++)
                {
                    s += load[j++];
                }
                mytimer.time = Int32.Parse(s);
                s = "";

                for (int i = ++j; load[i] != '!' && i < load.Length - 1; i++)
                {
                    s += load[j++];
                }
                LDiff.Text = s;
                s = "";

                for (int i = ++j; i < load.Length; i++)
                {
                    int x = (i - j) % 9,
                        y = (i - j) / 9,
                        v = Int32.Parse("" + load[i]);
                    if (v != 0)
                        kod.SetValue((object)v, x, y);
                    else
                        kod.SetValue(null, x, y);
                    kod.GetCell(x, y).ReadOnly = false;

                }

                for (int i = 0; i < startVals.Length; i++)//дописываем значения в массив startVals и блокируем редактирование у начальных ячеек
                {
                    DataGridViewCell o = kod.GetCell(startVals[i].x, startVals[i].y);
                    startVals[i].val = Convert.ToInt32(o.Value);
                    o.ReadOnly = true;
                }

                if (BNewgame.Visible)//если загружаемся с еще не начатой игрой
                    StartGame();

                Timer.Enabled = true;
            }
            OFD.FileName = "";
            //catch (Exception ex)
            // {
            //     MessageBox.Show("Error:" + ex.Message);
            // }
        }

        private void BEnd_Click(object sender, EventArgs e)//кнопка Закончить игру
        {
            EndGame();
        }

        private void Timer_Tick(object sender, EventArgs e)//тик таймера
        {
            if (Timer.Enabled)
            {
                LTimer.Text = mytimer.TimerString();
                mytimer.time += Timer.Interval + 10;
            }
        }
        ////////////////////////////////////////////////////////
        //кастомные события

        private void CellEndEdit(object sender, DataGridViewCellEventArgs e)//при редактировании ячейки
        {
            int x = 0;
            if (!(Int32.TryParse((string)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value, out x) && x > 0 && x < 10))//если не число от 1 до 9
                (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            else
                EndGameCheck();//проверка на конец игры

        }

        private void Grid_Leave(object sender, EventArgs e)//убрать выделение ячейки датагридвью после того, как указатель выйдет за его границы
        {
            (sender as DataGridView).ClearSelection();
            //(sender as DataGridView).CurrentCell = null;
        }

        //private void Grid_Leave(object sender, DataGridViewCellEventArgs e)
        //{
        //    (sender as DataGridView).ClearSelection();
        //    (sender as DataGridView).CurrentCell = null;
        // }

    }
}
