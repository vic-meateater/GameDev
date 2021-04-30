using System;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            static int StringLenght(string str)
            {
                return str.Length;
            }


            Console.Write("Введите число: ");
            string text = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Количества цифр в числе {text} - {StringLenght(text)}");
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadLine();
        }
    }
}
