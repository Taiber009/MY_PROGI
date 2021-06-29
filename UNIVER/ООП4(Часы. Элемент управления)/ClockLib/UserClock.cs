using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClockLib
{
    public partial class UserClock : UserControl
    {
        public UserClock()
        {
            InitializeComponent();
            //timer1.Enabled = true;
            mp = new MyPaint(ClientRectangle.Width, ClientRectangle.Height, DrawClock.CreateGraphics());
            FillTimeZones(TimeZones);
            DefTimer.Enabled = true;
        }
        MyPaint mp;
        private void ClockButton_Click(object sender, EventArgs e)
        {
            mp.SwitchClock();
        }

        private void DefTimer_Tick(object sender, EventArgs e)
        {
            mp.CheckClock(TimeZones.SelectedIndex); ;
        }
        private void FillTimeZones(ListBox tz)
        {
            string[] s = { "UTC−11 Американское Самоа", "UTC−10 США (Гавайи)", 
                           "UTC−9 США (Аляска)", "UTC−8 Канада", 
                           "UTC−7 Канада", "UTC−6 Канада", 
                           "UTC−5 Канада", "UTC−4 Канада", 
                           "UTC−3 Дания (Гренландия)", "UTC−2 Атл. Океан",
                           "UTC−1 Португалия (Азорские острова)", "UTC+0 Великобритания",
                           "UTC+1 Германия", "UTC+2 Латвия", 
                           "UTC+3 Воронеж", "UTC+4 Россия",
                           "UTC+5 Казахстан","UTC+6 Киргизия",
                           "UTC+7 Монголия","UTC+8 Китай",
                           "UTC+9 Япония","UTC+10 Австралия",
                           "UTC+11 Соломоновы острова","UTC+12 Маршалловые острова",};
            tz.DataSource = s;
            //tz.Items.Add(TimeZoneInfo.Con);
        }

        private void UserClock_Load(object sender, EventArgs e)
        {

        }
    }
}
