/*
 * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 * б) Сделать задание, только вывод организовать в центре экрана.
 * в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 * 
 * 
 * ---
 * Виктор Мясоедов 
 */


using System;

namespace EX_5
{
    class Program
    {
        static void Print (string firstName = "Виктор", string lastName = "Мясоедов", string city = "Челябинск", int row = 3)
        {
            int fullStringLenght = firstName.Length + lastName.Length + city.Length + 5;
            int consoleCenter = Convert.ToInt32(Console.WindowWidth / 2);
            Console.SetCursorPosition(consoleCenter - fullStringLenght / 2, row);
            Console.WriteLine($"в) {firstName} {lastName} {city}");
        }
        static void Main(string[] args)
        {

            string firstName = "Виктор";
            string lastName = "Мясоедов";
            string city = "Челябинск";
            int fullStringLenght = firstName.Length + lastName.Length + city.Length + 5; // +5 - буква задания, пробел и 2 пробела между имменем и фамилией
            int consoleCenter = Convert.ToInt32(Console.WindowWidth / 2);

            Console.Write($"а) {firstName} {lastName} {city}");
            Console.SetCursorPosition(consoleCenter - fullStringLenght/2, 2);
            Console.WriteLine($"б) {firstName} {lastName} {city}");
            Print();
            Console.ReadLine();

            
        }
    }
}
