using EX_1.Checkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1
{
    class Menu
    {
        public static void LetsGo()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Создать программу, которая будет проверять корректность ввода логина.");
                Console.WriteLine("Для выбра нажмите a/b, ESC для выхода.");
                Console.WriteLine("a) без использования регулярных выражений;");
                Console.WriteLine("b) **с использованием регулярных выражений.\n");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        CheckLogin.Check();
                        break;
                    case ConsoleKey.B:
                        CheckLoginRegex.Check();
                        break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
