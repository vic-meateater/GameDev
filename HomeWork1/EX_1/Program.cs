/*1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:

а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.

---
Виктор Мясоедов 

*/


using System;

namespace EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные для Анкеты:");
            Console.Write("Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();
            Console.Write("Возраст (полных лет): ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Рост (см): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вес (кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Имя: " + firstName + ". Фамилия: " + lastName + ". Возраст: " + age + ". Рост: " + height + ". Вес: " + weight + ".");
            Console.WriteLine("Имя: {0}. Фамилия: {1}. Возраст: {2}. Рост: {3}. Вес: {4}.", firstName, lastName, age, height, weight);
            Console.WriteLine($"Имя: {firstName}. Фамилия: {lastName}. Возраст: {age}. Рост: {height}. Вес: {weight}.");

            Console.ReadLine();
        }
    }
}
