/*
 1. Создать программу, которая будет проверять корректность ввода логина.
Корректным логином будет строка от 2 до 10 символов,
содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.


--
Виктор Мясоедов
 */

using System;
using System.Text.RegularExpressions;

namespace EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //CheckLogin();
            CheckLoginRegex();
        }

        static void CheckLogin()
        {
            static bool IsChar(char c) => c >= 'a' && c <= 'z';
            bool flag = true;
            while (flag)
            {
                Console.Clear();
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
                            Console.WriteLine("Логин должен состоять из букв латинского алфавита.");
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
        static void CheckLoginRegex()
        {
            Regex regex = new Regex(@"^[a-z,A-Z][a-z,A-Z,\d]{1,9}$");
            while (true)
            {
                Console.Write("Enter login: ");
                string login = Console.ReadLine();
                Console.WriteLine(regex.IsMatch(login));
                if (regex.IsMatch(login))
                {
                    Console.WriteLine("Login Okay!");
                    break;
                }
                else Console.WriteLine("Корректной строкой бла бла бла");
            }
        }
    }

}

