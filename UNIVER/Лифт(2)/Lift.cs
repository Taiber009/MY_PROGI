using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лифт_2_
{
    class Lift
    {
        public Man[] Users; //массив пользователей лифта (через очередь нормальный лифт не получается сделать, пришлось делать подобие хеш-таблицы)
        public int UsersCount; //кол-во пользователей
        public Queue<int> Targets; //очередь этажей, куда лифту надо приехать, чтобы забрать людей с этажей
        public Queue<int> TargetsByUsers;//очередь этажей, куда лифту надо отвезти пользователей(она приоритетнее)
        public int TargetNow; //куда едет сейчас
        public int Floor; //на каком этаже сейчас
        public int LastFloor; //прошлый этаж лифта(чтобы отчисить ячейку в Grid)
        // эти поля, наверно, надо вынести в другой класс (класс с общими значениями), тк с лифтом имеют мало общего 
        public Random Rand = new Random();
        public int FloorCount; //кол-во этажей
        public int ManCount;//кол-во людей
        public int N;//ползунок

        public Lift(int a, int b)  //конструктор класса
        {
            Targets = new Queue<int>();
            TargetsByUsers = new Queue<int>();
            FloorCount = a;
            Floor = a - Rand.Next(0, a) - 1; //потому что строки в Grid идут от 0 до a (первый этаж вверху)
            LastFloor = Floor;
            TargetNow = -1;
            ManCount = b;
            Users = new Man[6]; //ограничение на 6 человек в лифте(у меня так)
            for (int i = 0; i < 6; i++)
                Users[i] = null;
            UsersCount = 0;
            N = 0;
        }
        public int Spawn() //появление(спавн) людей, ждущих лифт (этот метод, наверное, надо вынести с класса лифта)
        {
            int Roll = Rand.Next(0, ManCount * (21-N)); //от 20 зависит вероятность появления кого-либо, меньше число - чаще спавн
            if (Roll < ManCount) //если число попало в массив людей
            {
                return Roll;
            }
            else return -1;  //если нет
        }
        public void NewUser(Man m) //добавляем нового пользователя лифта
        {
            bool vse = false;
            int i = 0;
            while (!vse) //идем по массиву пользователей лифта, пока не найдем пустую ячейку
                if (Users[i] == null)
                {
                    Users[i] = new Man("", -1);
                    Users[i] = m; //кладем в ячейку
                    vse = true; //и завершаем
                }
                else
                    i++;
            UsersCount++; //+1 пользователь лифта
            if (TargetNow == m.Floor) //если сейчас у лифта цели нет
                TargetNow = m.Target; //то новый пользователь предложит свою
            else //если уже есть цель у лифта
                TargetsByUsers.Enqueue(m.Target); //то цель пользователя кладется в очередь целей лифта
        }
        public bool DeleteUsers(int f) //удаляем всех пользователей лифта, у кого этаж равен f(они приехали на свой этаж)
        {
            bool open = false;
            for (int i = 0; i < 6; i++)
                if (Users[i] != null) //иначе след. проверка даст ошибку
                    if (Users[i].Target == f)
                    {
                        open = true; //если хоть 1 пользователь вышел, то дверь открылась
                        Users[i].Here = false; //он вышел из лифта, значит его можно спавнить заного(именно что меняем поле Here у человека из массива manAll,хз почему так)
                        Users[i] = null; //очищаем ячейку
                        UsersCount--; //-1 пользователь лифта
                    }    //Основная цель этого метода - удаление приехавших пользователей, открытие двери нужно
            return open; //если дверь открылась, зашли новые пользователи(если они есть), даже если лифт ехал вверх
                         //(если бы лифт ехал вверх и дверь не открылась, новые люди в лифт не зашли бы)
                         

        }
        public string Who() //выводит строку с именами и их таргетами для Grid
        {
            string s = "(" + UsersCount + " польз.)" + "[";
            for (int i = 0; i < 6; i++)
                if (Users[i] != null)
                {
                    int f = Users[i].Target + 1;
                    s += Users[i].Name + '(' + f + ") ";
                }
            s += ']';
            return s;
        }
        public void FloorMinus() //понижаем этаж у лифта и его пассажиров
        {
            Floor--;
            for (int i = 0; i < 6; i++)
                if (Users[i] != null)
                    Users[i].Floor--;
        }
        public void FloorPlus() //аналогично повышаем
        {
            Floor++;
            for (int i = 0; i < 6; i++)
                if (Users[i] != null)
                    Users[i].Floor++;
        }

        public void CleanQueue() //удаляем из очередей целей тот этаж, который равен нынешнему этажу лифта(потому что мы забрали(или выгрузили) человека в(из) лифт(а) до того, как дошла его очередь в Target)
        {
            Queue<int> q = new Queue<int>();
            int i;
            while (Targets.Count != 0)
            {
                i = Targets.Dequeue();
                if (i != Floor)
                    q.Enqueue(i);
            }
            Targets = q;
            q = new Queue<int>();
            while (TargetsByUsers.Count != 0)
            {
                i = TargetsByUsers.Dequeue();
                if (i != Floor)
                    q.Enqueue(i);
            }
            TargetsByUsers = q;
        }
    }
}
