using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1.Models
{
    class MyArrays
    {
        int size, minValaue, maxValue;

        public MyArrays(int size=10, int minValaue=-10, int maxValue=10)
        {
            this.size = size;
            this.minValaue = minValaue;
            this.maxValue = maxValue;
        }

        private int[] RandomArray()
        {
            var rand = new Random();
            int[] someArray = new int[size];
            for (int i = 0; i < someArray.Length; i++) someArray[i] = rand.Next(minValaue, maxValue);
            Console.WriteLine("Текущий рандомный массив: ");
            foreach (int elem in someArray)
            {
                Console.Write($"{elem}; ");
            }
            return someArray;
        }
        public void WriteArray()
        {
            Console.WriteLine($"{size}, {minValaue}, {maxValue}");
        }

        public int Sum()
        {
            int[] someArray = RandomArray();
            int count = 0;
            Console.WriteLine("\nВычисляем сумму массива:");
            foreach (int elem in someArray)
            {
                count += elem;
            }
            return count;
        }


        public void Inverse()
        {
 
            int[] someArray = RandomArray();
            Console.WriteLine("\nПоменяли знаки: ");
            int[] reversArray = new int[someArray.Length];
            for (int i =0; i<reversArray.Length; i++)
            {
                reversArray[i] = someArray[i] * -1;
                Console.Write($"{reversArray[i]}; ");
            }
        }

        public void Multi(int z)
        {
            int[] someArray = RandomArray();
            
            //Console.WriteLine("Текущий массив: ");
            //foreach (int elem in someArray)
            //{
            //    Console.Write($"{elem}; ");
            //}
            Console.WriteLine($"\nУмножили на {z}: ");
            for (int i = 0; i < someArray.Length; i++)
            {
                someArray[i] = someArray[i] * z;
                Console.Write($"{someArray[i]}; ");
            }

        }
    }
}
