using System;
using EX_1.Infrastructure;

namespace EX_1.View
{
    public class ConsoleView
    {
        public void Print(string msg)
        {
            Console.WriteLine($"Ответ: {msg}");
        }

        public Complex GetData()
        {
            Console.Write("Введите действительную часть числа: ");
            double.TryParse(Console.ReadLine(), out double re);
            Console.Write("Введите мнимую часть числа: ");
            double.TryParse(Console.ReadLine(), out double im);
            return new Complex(re, im);
        }
    }
}
