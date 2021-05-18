using System;
using System.Collections.Generic;
using System.Globalization;

namespace EX_2
{
    public class View
    {
        Functions func = new();
        InOut inOut = new();
        public void Print(string msg)
        {
            Console.Write(msg);
        }

        public void PrintResults(double start, double end, double step, double[] values)
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }

        public void ChooseInterval()
        {
            List<Fun> functions = new() { new Fun(func.secondDegree), new Fun(func.thirdDegree), new Fun(func.mySqrt), new Fun(func.Sin) };
            Console.WriteLine("Выберите функцию для дальнейшей работы.");
            Console.WriteLine("1) f(x)=y^2");
            Console.WriteLine("2) f(x)=y^3");
            Console.WriteLine("3) f(x)=y^1/2");
            Console.WriteLine("4) f(x)=Sin(y)");
            int userChoose = func.GetInt(functions.Count);

            Console.WriteLine("Задайте отрезок для нахождения минимума в формате 'х1 х2':");

            func.GetInterval(out double start, out double end);

            Console.WriteLine("Величина шага:");
            double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            inOut.Save("data.txt", start, end, step, functions[userChoose - 1]);
            double min = double.MaxValue;
            Console.WriteLine("Получены следующие значения функции: ");
            PrintResults(start, end, step, inOut.Load("data.txt", out min));
            Console.WriteLine("Минимальное значение функции равняется: {0:0.00}", min);
            Console.ReadLine();
        }
    }
}
