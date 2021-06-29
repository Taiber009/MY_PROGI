using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Лифт_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k = 0; //подсчет тиков таймера
        Man[] manAll; //объявления экземпляров массива классов люди, класса лифта и массива классов этажи(Man.cs, Lift.cs, Floor.cs)
        Lift lift; //экземпляры классов(lift, manAll) написаны с маленькой буквы; методы и поля этих классов(MinusFloor,TargetNow,Who и тд) с большой, просто для удобства
        Floor[] floorsAll;
        private void Go_Click(object sender, EventArgs e)
        {
            Go.Visible = false; 
            Box.Visible = false;
            Box2.Visible = false;
            Time.Visible = true;
            Track.Visible = true;
            int a = Int32.Parse(Box.Text), //кол-во этажей
                b = Int32.Parse(Box2.Text); //кол-во людей

            info1.Text += " = " + a; 
            info2.Text += " = " + b;

            Grid.RowCount = a; //кол-во этажей(строк в гриде)
            Grid.ColumnCount = 3; //(этаж, где ждут люди, и шахта лифта(столбцы в гриде)
            Grid.Columns[0].Name = "№";
            Grid.Columns[1].Name = "Этаж";// переименование колонок в Grid
            Grid.Columns[2].Name = "Лифт";
            Grid.Columns[0].Width = 30;
            Grid.Columns[1].Width = 200;//задание ширины колонок
            Grid.Columns[2].Width = 400;

            manAll = new Man[b]; //инициализация экземпляра массива класса "Люди"
            lift = new Lift(a, b);//инициализация экземпляра класса "Лифт"
            floorsAll = new Floor[a];//инициализация экземпляра массива класса "Этажи"
            for (int i = 0; i < a; i++)
            {
                floorsAll[i] = new Floor();//инициализация экземпляров в массиве класса "Этажи"
                Grid.Rows[a - 1 - i].Cells[0].Value = i + 1;//номера этажей в Grid
            }
            for (int i = 0; i < b; i++)
                manAll[i] = new Man("Имя" + i, lift.Rand.Next(0, lift.FloorCount));//у каждого человека есть имя, которое является порядком в массиве, 
            //                                                                    и этаж, где он сейчас находится(задается рандомом)
            //                                                                    также это инициализация экземпляров в массиве класса "Люди"

            /*//тоже самое через foreach
            int i = 0; //чтобы пройти по массиву людей через форыч
            foreach (Man j in manAll)
            {
                manAll[i++] = new Man("" + i, a - lift.rand.Next(0, a)); 
            }*/
            Ti.Enabled = true; //активируем таймер
        }


        private void Ti_Tick_1(object sender, EventArgs e)
        {//все это проиходит за 1 тик таймера
            info3.Text = "" + 5*(lift.N)+"%";
            bool DoorOpen = lift.DeleteUsers(lift.Floor);//удаляем всех пользователей лифта, которые приехали на нужный этаж, так же дверь открывается на этом этаже(это важно)
            if (DoorOpen)//если мы кого-то выгрузили, то лифту больше не зачем сюда ехать, тк мы выгрузили/забрали(это в след if) людей до их очереди в Targets или TargetsByUsers
                lift.CleanQueue();//удаляем из очереди целей тот этаж, который равен нынешнему этажу лифта

            if ((floorsAll[lift.Floor].ManQueue.Count != 0) && ((lift.TargetNow <= lift.Floor) || (DoorOpen))) 
            {//если на этаже с лифтом есть ожижающие и он едет вниз(если вверх, попутчиков не берет(у меня так дома лифт работает)) или дверь открылись(тогда берет, конечно), тк из лифта вышли люди
                while (lift.UsersCount < 6 && floorsAll[lift.Floor].ManQueue.Count != 0) //пока лифт не будет перегружен или все люди с этажа зайдут
                {
                    Man m = floorsAll[lift.Floor].DeleteUser(); //будут удалятся люди с этажа
                    lift.NewUser(m);                            //и добавляться в лифт
                }
                lift.CleanQueue(); //удаляем из очереди целей тот этаж, который равен нынешнему этажу лифта
                Grid.Rows[lift.FloorCount - 1 - lift.Floor].Cells[1].Value = floorsAll[lift.Floor].Who; //обновляем стринговую строку этажа для Grid
            }

           

            if (lift.TargetNow != -1) //если есть цель
            {
                if ((lift.Floor > lift.TargetNow)) //если цель ниже лифта
                    lift.FloorMinus(); //понижаем этаж лифта и его пассажиров
                else if ((lift.Floor < lift.TargetNow)) //аналогично если выше
                    lift.FloorPlus(); //повышаем
                else if (lift.UsersCount != 0)//если мы приехали на цель (уже выгрузили пассажиров с помощью DeleteUsers), то ищем новую цель
                    lift.TargetNow = lift.TargetsByUsers.Dequeue();  //берем цель из очереди целей пассажиров
                else if (lift.Targets.Count != 0)//если в очереди целей ожидающих есть какая-нибудь цель
                    lift.TargetNow = lift.Targets.Dequeue();//берем цель из очереди целей ожидающих
                else
                    lift.TargetNow = -1;  //нет цели(даже в очередях)
            } 
            else//if (lift.TargetNow == -1)//если цели у лифта нет, а в очередях целей они еще есть, берем цель для лифта из одной из очереди
                if (lift.TargetsByUsers.Count > 0) //из очереди пользователей лифта
                    lift.TargetNow = lift.TargetsByUsers.Dequeue();
                else if (lift.Targets.Count > 0) //из очереди ожидающих лифт
                    lift.TargetNow = lift.Targets.Dequeue();

            int Rolled;
            if (lift.N != 0)
                Rolled = lift.Spawn();  //пытаемся спавнить человека, который будет ожидать лифт
            else
                Rolled = -1;
            if ((Rolled != -1) && (manAll[Rolled].Here == false)) //если нашли номер человека из массива людей и его еще нет на этаже или в лифте и на этаже, то спавним его
            {//Rolled - номер заспавненного человека в массиве людей
                manAll[Rolled].Here = true; //он тут, спавнить еще раз его не надо
                manAll[Rolled].Target = lift.Rand.Next(0, lift.FloorCount); //рандомим ему цель, на какой этаж он хочет поехать
                while (manAll[Rolled].Target == manAll[Rolled].Floor) //если цель человека=его нынишний этаж, то рандомим заного
                    manAll[Rolled].Target = lift.Rand.Next(0, lift.FloorCount);
                floorsAll[manAll[Rolled].Floor].NewUser(manAll[Rolled]); //добавляем его в очередь на этаже, где он заспавнился (manAll[Rolled].Floor)
                Grid.Rows[lift.FloorCount - 1 - manAll[Rolled].Floor].Cells[1].Value = floorsAll[manAll[Rolled].Floor].Who; //обновляем строку ждущих лифт на этом этаже
                if (floorsAll[manAll[Rolled].Floor].ManQueue.Count == 1) //если он первый на этом этаже, добавляем цель для лифта, чтобы он сюда приехал
                    if (lift.TargetNow == -1) //если у него целей нет(и очередь целей пуста)
                        lift.TargetNow = manAll[Rolled].Floor; //лифт сразу едет сюда
                    else
                        lift.Targets.Enqueue(manAll[Rolled].Floor); //цель в очередь
            }

            Grid.Rows[lift.FloorCount - 1 - lift.Floor].Cells[2].Value = lift.Who(); //обновляем стринговую строку лифта для Grid
            if (lift.Floor != lift.LastFloor) //если лифт двигался
                Grid.Rows[lift.FloorCount - 1 - lift.LastFloor].Cells[2].Value = null;//очищаем прошлую ячейку лифта в Grid
            lift.LastFloor = lift.Floor;

            Time.Text = "Тики:" + k++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Track_ValueChanged(object sender, EventArgs e)
        {
            lift.N = Track.Value;
        }



    }
}
