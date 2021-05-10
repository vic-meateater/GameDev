using System;
using EX_2.Presenter;

namespace EX_2.Infrastucture
{
    public class Menu
    {
        public static void Start()
        {
            Calc calc = new Calc(new View.ConsoleView());
            calc.Sum();
        }
    }
}
