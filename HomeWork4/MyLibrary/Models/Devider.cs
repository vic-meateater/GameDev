using System;
namespace EX_1.Models
{
    public class Devider
    {
        private int Algo(int[] someArray)
        {
            int count = 0;
            Console.WriteLine("Задание 1, 2: ");
            for (int i = 0; i < someArray.Length; i++)
            {
                Console.Write($"{someArray[i]}; ");
                try
                {
                    int check = someArray[i + 1];
                }
                catch
                {
                    return count;
                }
                if (someArray[i] % 3 == 0 || someArray[i + 1] % 3 == 0) count++;
                if (someArray[i] % 3 == 0 && someArray[i + 1] % 3 == 0) count--;
            }
            return count;
        }
        public int DevideFromArray(int arrayMin, int arrayMax)
        {
            int[] someArray = new int[20];
            var rand = new Random();
            for (int i = 0; i < someArray.Length; i++) someArray[i] = rand.Next(arrayMin, arrayMax);
            return Algo(someArray);
        }

        public int DevideFromFile(int[] someArray)
        {
            return Algo(someArray);
        }
    }
}
