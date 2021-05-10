using System;
using EX_1.Presenter;

namespace EX_1.Infrastructure
{
    public class Menu
    {
        public static void Start()
        {
            Calc calc = new Calc(new View.ConsoleView());
            while (true)
            {
                Console.WriteLine("\n\nДля вычесления суммы комплексных чисел нажмите \"a\"\nДля умножения \"m\"\nДля вычитания \"s\"\nДля выхода ESC.\n\n ");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        calc.Add();
                        break;
                    case ConsoleKey.M:
                        calc.Multiply();
                        break;
                    case ConsoleKey.S:
                        calc.Subtract();
                        break;
                    case ConsoleKey.Escape: return; 
                }
            }
        }
    }
}
