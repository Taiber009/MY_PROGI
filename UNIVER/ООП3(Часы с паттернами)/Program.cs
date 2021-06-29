using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ООП3__Часы_с_паттернами_
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
