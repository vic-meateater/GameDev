using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2
{
    class GetData
    {
        public static string GetString()
        {
            Console.Write("Введите сообщение: ");
            string str = Console.ReadLine();
            return str;
        }
        public static char GetSymbol()
        {
            Console.Write("Введите символ: ");
            char symb = Convert.ToChar(Console.ReadLine());
            return char.ToLower(symb);
        }
        public static int GetLenght()
        {
            Console.Write("Введите длину слова: ");
            int len = Convert.ToInt32(Console.ReadLine());
            return len;
        }
    }
}
