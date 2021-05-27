using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4_5
{
    class View
    {
        Converter converter = new();
        public void Convert()
        {
            converter.ConvertFiles(@"students.csv", "students.xml");

            Console.WriteLine("Работа программы завершена!");
            Console.ReadLine();
        }
    }
}
