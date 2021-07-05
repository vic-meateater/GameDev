using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4_5
{
    class Menu
    {
        public static void Start()
        {
            View view = new();
                Console.Clear();
                Console.WriteLine("Конвертер из CSV в XML-файл с информацией о студентах");
                view.Convert();
        }
    }
}
