using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ООП3__Часы_с_паттернами_
{
    class Observer
    {
        string[] alarms;
        SoundPlayer sp;
        MyPaint mypaint;
        string timeInClacc;
        public Observer(MyPaint mp)
        {
            mypaint = mp;
            alarms = new string[0];
            sp = new SoundPlayer(Application.StartupPath + @"\Музон\1.wav");
            //timeInClacc = ;
        }
        public void UPD()//сигнал на обновления часов
        {
            string nowtime = DateTime.Now.ToString();
            if (timeInClacc != nowtime)//если время с последнего раза обновилось
            {
                timeInClacc = nowtime;
                string[] splited = nowtime.Split();//сплит даты и времени
                mypaint.UpdateTime(splited[1], splited[0]);//отправка времени на отрисовку
                AlarmCheck(splited[1]);//проверка на будильник
            }
            
        }
        public void AlarmCheck(string time)
        {
            foreach (string s in alarms)
                if (time == s+":00")
                {
                    sp.PlayLooping();//музыка!
                    MessageBox.Show("АЛЯРМ! " + s);//можно было добавить название будильника, но это надо еще его писать на форме
                    sp.Stop();
                    break;
                }      
        }
        public void AddAlrm(string time)
        {
            for (int i = 0; i < alarms.Length;i++ )
            {
                if(alarms[i]==null)
                {
                    alarms[i] = time;
                    return;
                }
            }
            Array.Resize<string>(ref alarms, alarms.Length + 1);
            alarms[alarms.Length - 1] = time;
            return;
        }
        public void DelAlrm(int i1)
        {
            for (int i=i1;i<alarms.Length-1;i++)
            {
                alarms[i]=alarms[i+1];
                alarms[i+1]=null;
            }
        }
        
    }
}
