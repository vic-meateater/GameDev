using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1.Checkers
{
    class CheckLogin
    {
        public static void Check()
        {
            static bool IsChar(char c) => c >= 'a' && c <= 'z';
            bool flag = true;
            while (flag)
            {

                Console.Write("Login: ");
                string login = Console.ReadLine();
                if (login.Length < 2 || login.Length > 10)
                {
                    Console.WriteLine($"Вы ввели: {login}, длина: {login.Length}");
                    Console.WriteLine("А надо было >=2 и =<10 симоволов. \nПопробуйте еще разок.");
                    Console.ReadLine();

                }
                else if (char.IsDigit(login[0]))
                {
                    Console.WriteLine("Логин не может начинаться с цифр.");
                    Console.ReadLine();
                }
                else
                {
                    foreach (char elem in login)
                    {
                        if (!IsChar(elem) && !char.IsDigit(elem))
                        {
                            Console.WriteLine("Логин должен состоять из букв латинского алфавита.\nПопробуйте еще разок.");
                            Console.ReadLine();
                            flag = true;
                            break;
                        }
                        else flag = false;
                    }
                }
            }
            Console.WriteLine("Login Ok!");
            Console.ReadLine();
        }
    }
}
