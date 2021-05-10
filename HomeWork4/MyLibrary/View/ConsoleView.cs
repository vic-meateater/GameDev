using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1.View
{
    class ConsoleView
    {
        public void SomePrint(string msg)
        {
            Console.Write("\nОтвет: ");
            Console.WriteLine(msg);
            Console.ReadLine();
        }

        public int[] GetData(int minValue=-10000, int maxValue=10000)
        {
            int[] array0 = { minValue, maxValue };
            return array0;
        }

        public int[] GetDataFromFile()
        {
            string path = "file.txt";
            if (File.Exists(path))
            {
                string[] array0 = File.ReadAllLines(path);
                int[] array1 = Array.ConvertAll(array0, s => Convert.ToInt32(s));
                Console.WriteLine("Считываем из файла...");
                return array1;
            }
            else
            {
                Console.WriteLine("File does not exist");
                Console.ReadLine();
                return null;
            }
        }

        public int GetInt()
        {
            Console.WriteLine("\n\nНа какое число умножить массив?: ");
            Console.Write("# ");
            int z = Convert.ToInt32(Console.ReadLine());
            return z;
        }

        public Dictionary<string, int> GetArrayData()
        {
            Dictionary<string, int> arrayData = new();
            Console.WriteLine("Задание 3: ");
            Console.Write("Введите размер массива: ");
            arrayData.Add("size", Convert.ToInt32(Console.ReadLine()));
            Console.Write("Генерировать массив от: ");
            arrayData.Add("minValue", Convert.ToInt32(Console.ReadLine()));
            Console.Write("До: ");
            arrayData.Add("maxValue", Convert.ToInt32(Console.ReadLine()));
            return arrayData;
        }

    }
}
