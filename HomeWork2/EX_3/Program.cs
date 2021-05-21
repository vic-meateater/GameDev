/*
 3. С клавиатуры вводятся числа, пока не будет введен 0.
Подсчитать сумму всех нечетных положительных чисел.


--
Виктор Мясоедов
*/

using System;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber, oddNumbers = 0;
            do
            {
                Console.Write("Введите число: ");
                userNumber = Int32.Parse(Console.ReadLine());
                if (userNumber % 2 != 0 && userNumber > 0)
                {
                    oddNumbers += userNumber;
                }
            }
            while (userNumber != 0) ;
            Console.Write($"сумму всех нечетных положительных чисел: {oddNumbers}");
            
        }
    }
}
