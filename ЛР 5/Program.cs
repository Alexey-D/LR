using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Система
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
            Application.Run(new Учёт());
        }
    }
    // Класс с глобальными статическими параметрами, предназначенными для полей учётного модуля
    static class Global
    {
        public static int Equations = 0;
        public static int Records = 4;
    }
}
