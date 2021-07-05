using System;
using System.Collections.Generic;

namespace EX_2
{
    public class Menu
    {
        public static void Start()
        {
            View view = new();
            Console.WriteLine("Вас приветсвует программа нахождения минимума функции!");
            view.ChooseInterval();
        }
    }
}
