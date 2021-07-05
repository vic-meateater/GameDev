using System;
using System.Text;

namespace EX_2
{
    public class Message
    {
        public Message()
        {
        }
        public static void NoMoreThan(string str, int len)
        {
            string[] splitString = str.Split();
            Console.WriteLine($"Слова не больше {len} букв: ");
            foreach (string elem in splitString)
            {
                if (elem.Length <= len) Console.Write($"{elem} ");
            }
            Console.ReadLine();
        }
        public static void BySymbol(string str, char symb)
        {
            string[] splitString = str.Split();
            foreach(string elem in splitString)
                Console.WriteLine(elem);
            for (int i=0; i<splitString.Length; i++)
            {
                char c = splitString[i][^1];
                if (c.Equals(symb)) Array.Clear(splitString, i, 1);
            }
            foreach (string elem in splitString)
                Console.WriteLine(elem);
            Console.ReadLine();
        }

        public static void FindLong(string str)
        {
            string[] splitString = str.Split();
            string longWord = "";
            StringBuilder sb = new();

            for (int i=0;i<splitString.Length; i++)
            {
                if (splitString[i].Length > longWord.Length) longWord = splitString[i];
                if (splitString[i].Length >= longWord.Length) sb.Append(splitString[i]);
            }
            Console.WriteLine($"Самое длинное слово: {longWord}");
            Console.WriteLine($"Строка из длинных слов: {sb}");
        }
    }
}
