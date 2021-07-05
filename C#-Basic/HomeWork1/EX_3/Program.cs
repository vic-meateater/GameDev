/*
 * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
 * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 * 
 * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
 * 
 * 
 * ---
 * Виктор Мясоедов 
 */
using System;

namespace EX_3
{
    class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine($"a) Расстояние между точками: {r:f3}");
            Console.WriteLine("\nЕщё разок, только вычисления с помощью метода.");
            Console.WriteLine($"\nб) Расстояние между точками: {Distance(x1, y1, x2, y2):F3}");
            Console.ReadLine();

            
        }



        
    }
}
