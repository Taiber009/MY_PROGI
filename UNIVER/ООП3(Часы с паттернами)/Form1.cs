using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Globalization;

namespace ООП3__Часы_с_паттернами_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DefTimer.Enabled = true;
            mp = new MyPaint(ClientRectangle.Width, ClientRectangle.Height, DrawClock.CreateGraphics());
            o = new Observer(mp);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //DoubleBuffered = true;
        }
        Stopwatch sw;
        Observer o;
        MyPaint mp;
        int kryg = 1;
 
        // Секундомер в обе стороны с отметками, будильник, Паттерны: Слушатель (Observer), Decorator.

        //observ - будильник
        //decor - аналог или цифр часы
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (MyTimerLabel.Visible && MyTimerLabel.Enabled)
            {
                sw.time += (DefTimer.Interval + 9) * sw.multiplier;
                MyTimerLabel.Text = sw.TimerString();
            }
            o.UPD();
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            //смена названия кнопки таймера
            if (!PauseButton.Visible)
                TimerButton.Text = "Стоп";
            else
                TimerButton.Text = "Старт секундомера";
            //обновление таймера и списка остановок
            if (!MyTimerLabel.Visible)
                sw = new Stopwatch();
            if (!TimerStopList.Visible)
            {
                TimerStopList.Items.Clear();
                kryg = 1;
            }
            //появление/скрытие кнопок
            MyTimerLabel.Visible = !MyTimerLabel.Visible;
            MyTimerLabel.Enabled = !MyTimerLabel.Enabled;
            if (!MyTimerLabel.Visible && MyTimerLabel.Enabled)//если стоп после паузы
                MyTimerLabel.Enabled = false;
            PauseButton.Visible = !PauseButton.Visible;
            ChangeMultiplierButton.Visible = !ChangeMultiplierButton.Visible;
            TimerStopList.Visible = !TimerStopList.Visible;
            KrygButton.Visible = !KrygButton.Visible;
        }

        private void ChangeMultiplier_Click(object sender, EventArgs e)
        {
            sw.Change();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            MyTimerLabel.Enabled = !MyTimerLabel.Enabled;
        }

        private void KrygButton_Click(object sender, EventArgs e)
        {
            TimerStopList.Items.Add("Круг " + (kryg++) + "   " + sw.TimerString());
        }

        private void PlusButton1_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(HoursText.Text);
            if (i != 23)
                HoursText.Text = "" + (i + 1);
            else
                HoursText.Text = "" + 0;
        }

        private void MinusButton1_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(HoursText.Text);
            if (i != 0)
                HoursText.Text = "" + (i - 1);
            else
                HoursText.Text = "" + 23;
        }

        private void PlusButton2_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(MinutesText.Text);
            if (i != 59)
                MinutesText.Text = "" + (i + 1);
            else
                MinutesText.Text = "" + 0;
        }

        private void MinusButton2_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(MinutesText.Text);
            if (i !=0)
                MinutesText.Text = "" + (i - 1);
            else
                MinutesText.Text = "" + 59;
        }

        private void AddAlarmButton_Click(object sender, EventArgs e)
        {
            AlarmList.Items.Add("Будильник " + "   " + HoursText.Text + ":" + Int32.Parse(MinutesText.Text) / 10 + "" + Int32.Parse(MinutesText.Text) % 10);
            o.AddAlrm(HoursText.Text + ":" + MinutesText.Text);
            //добавляем в лист новый элемент+добавляем время нового будильника в массив класса Observer с помощью AddAlrm

        }

        private void DelAlarmButton_Click(object sender, EventArgs e)
        {
            if (AlarmList.SelectedIndex >= 0)
            {
                //AlarmList.Items[AlarmList.SelectedIndex] = "Null";
                o.DelAlrm(AlarmList.SelectedIndex);
                AlarmList.Items.RemoveAt(AlarmList.SelectedIndex);
            }
        }

        private void ClockButton_Click(object sender, EventArgs e)
        {
            mp.SwitchClock();
        }
    }
}
