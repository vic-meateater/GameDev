/*
 


--
Виктор Мясоедов
 */
using System;

namespace EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static double MinOfThree(double a, double b, double c)
            {
                if (a < b && a < c)
                    return a;
                else if (b < a && b < c)
                    return b;
                else return c;

            }
            int a, b, c;
            Console.WriteLine("Введите три целых числа.");
            Console.Write("Первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число:");
            c = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Наибольшее число {MinOfThree(a, b, c)}");
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadLine();

        }
    }
}
