﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ClockLib
{
    class MyPaint
    {
        //public Bitmap bit;
        Pen myPen;
        SolidBrush myBrush;
        //Graphics graph;
        protected Drawer drawer;
        protected string timeInClacc;
        int myZone;
        public MyPaint(int h, int w, Graphics g)
        {
            //bit = new Bitmap(w, h);
            myZone = Int32.Parse(TimeZoneInfo.Local.ToString().Split(':')[0].Split('+')[1])+11;//(utc+03:00)
            myPen = new Pen(Color.Black, 4);
            myBrush = new SolidBrush(Color.Red);
            drawer = new Drawer(myPen, myBrush, g);
            drawer = new DrawerDigital(drawer);
        }
        public void SwitchClock()
        {
            if (drawer.clockCheck) drawer = new DrawerOldClock(drawer);
            else drawer = new DrawerDigital(drawer); ;
        }
        public void CheckClock(int t)
        {
            string nowtime = DateTime.Now.ToString();
            if (timeInClacc != nowtime)
            {
                if (t == -1)//если не выбран часовой пояс в листбоксе
                    t = myZone;
                timeInClacc = nowtime;
                string[] s = timeInClacc.Split(),
                    s2 = s[1].Split(':');
                int dev = Int32.Parse(s2[0]) - myZone + t % 24;
                if (dev < 0)
                    dev = 24 + dev;
                s[1] = dev + ":" + s2[1] + ":" + s2[2];
                //s2[1] = (Int32.Parse(s2[1].Split(':')[0]) + myZone - t).ToString();
                drawer.Draw(s[1], s[0]);
            }
        }
    }

    class Drawer : IDraw
    {
        internal bool clockCheck;
        protected Pen myPen;
        protected SolidBrush myBrush, backBrush;
        protected Graphics graph;
        protected Font myFont;
        protected int height, start, lenght, midrad, forString;
        public Drawer(Pen p, SolidBrush b, Graphics g)
        {
            myPen = p;
            myBrush = b;
            graph = g;
            backBrush = new SolidBrush(Color.Aqua);
            height = 300;
            start = 10;
            lenght = 320;
            midrad = 5;
            myFont = new Font("Arial", 25);
            forString = 70;
        }
        public Drawer(Drawer d)
        {
            myPen = d.myPen;
            myBrush = d.myBrush;
            graph = d.graph;
            backBrush = d.backBrush;
            height = d.height;
            start = d.start;
            lenght = d.lenght;
            midrad = d.midrad;
            myFont = d.myFont;
            forString = d.forString;
        }
        public virtual void Draw(string time, string date)
        {

        }
    }
    class DrawerDigital : Drawer
    {
        //public DrawerDigital(Pen p, SolidBrush b, Graphics g)
        //   : base(p,b,g)
        //{
        //    clockCheck = true;
        //}
        public DrawerDigital(Drawer d)
            : base(d)
        {
            clockCheck = true;
        }
        public override void Draw(string time, string date)
        {
            int recX = 60, recY = 120, lenX = 175, lenY = 65;
            graph.Clear(Color.SkyBlue);
            graph.DrawRectangle(myPen, recX, recY, lenX, lenY);
            graph.FillRectangle(backBrush, recX, recY, lenX, lenY);
            graph.DrawString(time, myFont, myBrush, recX, recY);//время
            graph.DrawString(date, myFont, myBrush, recX, recY + myFont.Size);//дата
        }
    }
    class DrawerOldClock : Drawer
    {
        public DrawerOldClock(Drawer d)
            : base(d)
        {
            clockCheck = false;
        }
        public override void Draw(string time, string date)
        {//160 - середина канвы, 320 - общая длинна
            double sLen = height / 2,
                   hLen = sLen / 3,//длина часовой стрелки
                   mLen = hLen * 2;
            int dev = 20;
            string[] splited = time.Split(':');//сплит "чч:мм:сс" на часы, минуты и секунды
            // Pen myPen = new Pen(Color.Red, 2);
            // myPen.PenType
            int hours = Int32.Parse(splited[0]),
                min = Int32.Parse(splited[1]),
                sec = Int32.Parse(splited[2]);
            graph.Clear(Color.SkyBlue);

            double pi_sec_min = Math.PI / 30,//коэффицент Pi для минут и секунд
                   pi_hours = Math.PI / 6;//для часов
            graph.DrawEllipse(myPen, start, start, height, height);//циферблат
            graph.FillEllipse(backBrush, start, start, height, height);//его заливка
            graph.DrawEllipse(myPen, lenght / 2 - midrad, lenght / 2 - midrad, midrad * 2, midrad * 2);//крепление стрелок (для красоты)
            graph.DrawString(date, myFont, myBrush, 70, lenght / 2);//дата
            //часовая стрелка
            graph.DrawLine(myPen,//основная линия стрелки
                        (int)(lenght / 2 - midrad * Math.Sin(pi_hours * hours * -1)),//минус радуис крепления стрелок
                        (int)(lenght / 2 - midrad * Math.Cos(pi_hours * hours)),
                        (int)(lenght / 2 - hLen * Math.Sin(pi_hours * hours * -1)),
                        (int)(lenght / 2 - hLen * Math.Cos(pi_hours * hours)));
            graph.DrawLine(myPen,//правое крыло
                        (int)(lenght / 2 - hLen * Math.Sin(pi_hours * hours * -1)),
                        (int)(lenght / 2 - hLen * Math.Cos(pi_hours * hours)),
                        (int)(lenght / 2 - (hLen - dev) * Math.Sin(pi_hours * (hours + 1) * -1)),
                        (int)(lenght / 2 - (hLen - dev) * Math.Cos(pi_hours * (hours + 1))));
            graph.DrawLine(myPen,//левое крыло
                        (int)(lenght / 2 - hLen * Math.Sin(pi_hours * hours * -1)),
                        (int)(lenght / 2 - hLen * Math.Cos(pi_hours * hours)),
                        (int)(lenght / 2 - (hLen - dev) * Math.Sin(pi_hours * (hours - 1) * -1)),
                        (int)(lenght / 2 - (hLen - dev) * Math.Cos(pi_hours * (hours - 1))));
            //минутная стрелка
            graph.DrawLine(myPen,//основная линия
                        (int)(lenght / 2 - midrad * Math.Sin(pi_sec_min * min * -1)),
                        (int)(lenght / 2 - midrad * Math.Cos(pi_sec_min * min)),
                        (int)(lenght / 2 - mLen * Math.Sin(pi_sec_min * min * -1)),
                        (int)(lenght / 2 - mLen * Math.Cos(pi_sec_min * min)));
            graph.DrawLine(myPen,//правое крыло
                        (int)(lenght / 2 - mLen * Math.Sin(pi_sec_min * min * -1)),
                        (int)(lenght / 2 - mLen * Math.Cos(pi_sec_min * min)),
                        (int)(lenght / 2 - (mLen - dev) * Math.Sin(pi_sec_min * (min + 1) * -1)),
                        (int)(lenght / 2 - (mLen - dev) * Math.Cos(pi_sec_min * (min + 1))));
            graph.DrawLine(myPen,//левое крыло
                        (int)(lenght / 2 - mLen * Math.Sin(pi_sec_min * min * -1)),
                        (int)(lenght / 2 - mLen * Math.Cos(pi_sec_min * min)),
                        (int)(lenght / 2 - (mLen - dev) * Math.Sin(pi_sec_min * (min - 1) * -1)),
                        (int)(lenght / 2 - (mLen - dev) * Math.Cos(pi_sec_min * (min - 1))));
            //секундная стрелка
            graph.DrawLine(myPen,//основная линия
                        (int)(lenght / 2 - midrad * Math.Sin(pi_sec_min * sec * -1)),
                        (int)(lenght / 2 - midrad * Math.Cos(pi_sec_min * sec)),
                        (int)(lenght / 2 - sLen * Math.Sin(pi_sec_min * sec * -1)),
                        (int)(lenght / 2 - sLen * Math.Cos(pi_sec_min * sec)));
            graph.DrawLine(myPen,//правое крыло
                        (int)(lenght / 2 - sLen * Math.Sin(pi_sec_min * sec * -1)),
                        (int)(lenght / 2 - sLen * Math.Cos(pi_sec_min * sec)),
                        (int)(lenght / 2 - (sLen - dev) * Math.Sin(pi_sec_min * (sec + 1) * -1)),
                        (int)(lenght / 2 - (sLen - dev) * Math.Cos(pi_sec_min * (sec + 1))));
            graph.DrawLine(myPen,//левое крыло
                        (int)(lenght / 2 - sLen * Math.Sin(pi_sec_min * sec * -1)),
                        (int)(lenght / 2 - sLen * Math.Cos(pi_sec_min * sec)),
                        (int)(lenght / 2 - (sLen - dev) * Math.Sin(pi_sec_min * (sec - 1) * -1)),
                        (int)(lenght / 2 - (sLen - dev) * Math.Cos(pi_sec_min * (sec - 1))));
            //стрелка секундомера

            //g.DrawString("12", new Font("Arial", 30),myBrush,130,20);
            //g.DrawString("1", new Font("Arial", 30), myBrush, 220, 40);
            //g.DrawString("6", new Font("Arial", 30), myBrush, 144, 260); 
            //g.DrawLine(myPen, 10, 10, 100, 100);
        }
    }
    interface IDraw
    {
        void Draw(string time, string date);
    }
}
