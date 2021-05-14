using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EX_1.Checkers
{
    class CheckLoginRegex
    {
        public static void Check()
        {
            Regex regex = new Regex(@"^[a-z,A-Z][a-z,A-Z,\d]{1,9}$");
            while (true)
            {
                Console.Write("Enter login: ");
                string login = Console.ReadLine();
                if (regex.IsMatch(login))
                {
                    Console.WriteLine("Login Okay!");
                    Console.ReadLine();
                    break;
                }
                else Console.WriteLine("Логин должен состоять из букв латинского алфавита.\nСодержать>=2 и =<10 симоволов. \nПопробуйте еще разок.");
            }
        }
    }
}
