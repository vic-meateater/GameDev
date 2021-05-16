using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2
{
    class Menu
    {
        public static void LetsGo()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:");
                Console.WriteLine("Для выбра нажмите a,b,c. ESC для выхода.");
                Console.WriteLine("a) Вывести только те слова сообщения, которые содержат не более n букв.");
                Console.WriteLine("b) Удалить из сообщения все слова, которые заканчиваются на заданный символ.");
                Console.WriteLine("c) Найти самое длинное слово сообщения.\nСформировать строку с помощью StringBuilder из самых длинных слов сообщения.\n");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Message.NoMoreThan();
                        break;
                    case ConsoleKey.B:
                        Message.BySymbol();
                        break;
                    case ConsoleKey.C:
                        Message.FindLong();
                        break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
