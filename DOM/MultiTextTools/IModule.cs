using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiTextTools
{
    interface IModule//интерфейс для модулей
    {
        string Answer(string input);//основой метод, преобразующий текст
        string Name();//выводит название модуля
        string Tip();//выводит описание модуля
    }
}
