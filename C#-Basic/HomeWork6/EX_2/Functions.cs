using System;

namespace EX_2
{
    public class Functions
    {
        public double secondDegree(double x)
        {
            return x * x;
        }

        public double thirdDegree(double x)
        {
            return x * x * x;
        }

        public double mySqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public double Sin(double x)
        {
            return Math.Sin(x);
        }

        public int GetInt(int max)
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                    Console.Write($"Неверный ввод (требуется числовое значение от 0 до {max}).\nПожалуйста повторите ввод: ");
                else return x;
        }

        public void GetInterval(out double start, out double end)
        {
            string[] interval = Console.ReadLine().Split(' ');
            start = double.Parse(interval[0]);
            end = double.Parse(interval[1]);
        }
    }
}
