using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX_1.Presenter;

namespace EX_1.Infrastructure
{
    public class Menu
    {
        public static void LetsRoll()
        {
            Massivius massivius = new Massivius(new View.ConsoleView());
            massivius.Devider();
            massivius.DeviderFromFile();
            massivius.MyArrayPrint();
            Console.ReadLine();
            
        }
    }
}
