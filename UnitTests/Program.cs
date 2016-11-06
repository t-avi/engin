using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTests
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        ///
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    //команда-подключиться
    //создать локальный
    //зайти в него и создать проект/скопировать готовый
    //произвести изменения, зайти в изменения
    //нетрассируемые изменения добавить,закоммитить
    //синхронизировать с гитом
}
