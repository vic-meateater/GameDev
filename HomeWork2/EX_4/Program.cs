/*
 4. Реализовать метод проверки логина и пароля.
На вход метода подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел
(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля,
написать программу: пользователь вводит логин и пароль,
программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.


--
Виктор Мясоедов
 */


using System;

namespace EX_4
{
    class Program
    {
        static bool CheckLogin(string login, string password)
        {
            if(login == "root" && password == "GeekBrains")
            {
                return true;
            }
            return false;    
        }
        static void Main(string[] args)
        {
            var tryLogin = 3;
            while (tryLogin-- > 0)
            {
                Console.Write("Enter Login: ");
                var userLogin = Convert.ToString(Console.ReadLine());
                Console.Write("Enter password: ");
                var userPassword = Convert.ToString(Console.ReadLine());
                if (CheckLogin(userLogin, userPassword))
                {
                    Console.WriteLine("Вы ввели правильные данные");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильные данные");
                }
            }



        }
    }
}
