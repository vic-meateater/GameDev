using System;
using System.Collections.Generic;
using System.Text;

namespace EX_2
{
    static public class Message
    {

        public static void NoMoreThan()
        {
            string str = GetData.GetString();
            int len = GetData.GetLenght();
            string[] splitString = str.Split();
            Console.WriteLine($"Слова не больше {len} букв: ");
            foreach (string elem in splitString)
            {
                if (elem.Length <= len) Console.Write($"{elem} ");
            }
            Console.ReadLine();
        }

        public static void BySymbol()
        {
            string str = GetData.GetString();
            char symb = GetData.GetSymbol();
            string[] splitString = str.Split();
            foreach (string elem in splitString)
                Console.WriteLine(elem);
            for (int i = 0; i < splitString.Length; i++)
            {
                char c;
                int charPos = 1;
                if (splitString[i].Length > 1)
                    while (!char.IsLetterOrDigit(c=splitString[i][^charPos]))
                        charPos++;
                else if (char.IsLetterOrDigit(splitString[i][0]))
                    c = splitString[i][0];  
                else c = splitString[i][0];
                if (char.ToLower(c).Equals(symb)) Array.Clear(splitString, i, 1);
            }
            Console.WriteLine("Оставшиеся слова: ");
            foreach (string elem in splitString)
                Console.Write($"{elem} ");
            Console.ReadLine();
        }

        public static string CheckWord(string word)
        {
            char[] ca = word.ToCharArray(); 
            for (int i = 0; i < ca.Length; i++)
                if (!char.IsLetterOrDigit(ca[i]))
                    word = word.Remove(i);
            return word;
        }
        public static void FindLong()
        {
            string str = GetData.GetString();
            string[] splitString = str.Split();
            string longWord = "";
            StringBuilder sb = new();

            for (int i=0;i<splitString.Length; i++)
            {
                string rightWord = CheckWord(splitString[i]);
                if (rightWord.Length > longWord.Length) longWord = rightWord;
                if (rightWord.Length >= longWord.Length) sb.Append(rightWord);
            }
            Console.WriteLine($"Первое самое длинное слово: {longWord}");
            Console.WriteLine($"Строка из длинных слов: {sb}");
            Console.ReadLine();
        }
    }
}
