/*
 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.


---
Виктор Мясоедов 
 */
using System;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Рост (м): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вес (кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"ИМТ: {weight/(height*height):F2}");

            Console.ReadLine();
        }
    }
}
