using System;
namespace EX_1
{
    public class Menu
    {
        public static void Start()
        {
            View view = new();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("a) Таблица функции MyFunc из методички:");
                Console.WriteLine("b) Таблица функции MyFuncTwo a* x^2:");
                Console.WriteLine("c) Таблица функции MyFuncThree a* sin(x):");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        view.GetFirst();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.B:
                        view.GetSecond();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.C:
                        view.GetThird();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
