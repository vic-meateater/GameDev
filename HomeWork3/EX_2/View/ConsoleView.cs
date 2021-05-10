using System;
using System.Collections.Generic;

namespace EX_2.View
{
    public class ConsoleView
    {
        public void Print(string msg)
        {
            Console.WriteLine($"Сумма всех нечётных положительных чисел: {msg}");
        }

        public int[] GetData()
        {
            List<int> listOfDigits = new List<int>();
            Console.WriteLine("Введите числа: ");

            while (true)
            {
                Console.Write("# ");
                bool flag = int.TryParse(Console.ReadLine(), out int x);
                if (!flag)
                {
                    Console.WriteLine("Введено не число, попробуйте еще разок...");
                }
                else if (x == 0)
                {
                    Console.WriteLine("Введен нулик, подсчитываем числа... ");
                    break;
                }
                else if (flag && x%2 != 0 && x>0)
                {
                    listOfDigits.Add(x);
                }
            }
            int[] someArray = listOfDigits.ToArray();
            return someArray;
        }
    }
}
