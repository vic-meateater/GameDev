/*
 * 
 * 
--
Виктор Мясоедов
 */

using System;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            static int StringLenght(int numb)
            {
                var count = 0;
                do
                {
                    count++;
                    numb /= 10;
                }
                while (numb != 0);
                return count;
            }


            Console.Write("Введите число: ");
            int text = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количества цифр в числе {text} - {StringLenght(text)}");
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadLine();
        }
    }
}
