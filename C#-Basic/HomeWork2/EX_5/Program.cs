/*
 а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы
и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


--
Виктор Мясоедов.
 */

using System;

namespace EX_5
{
    class Program
    {
        private static void MassCalc()
        {
            double index;
            double indexOfDeficitWeight = 16;
            double indexOfNormalWeight = 22;
            double indexOfOverWeight = 33;
            double correctUsersWeight;


            Console.Write("Введите свой вес в килограммах: ");
            double usersWeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост в сантиметрах: ");
            double usersHeight = Convert.ToDouble(Console.ReadLine()) / 100;

            index = usersWeight / (usersHeight * usersHeight);
            correctUsersWeight = indexOfNormalWeight * (usersHeight * usersHeight);

            if (index <= indexOfDeficitWeight)
            {
                Console.WriteLine($"У Вас острый дефицит веса. Для номализации " +
                    $"веса Вам следует набрать {correctUsersWeight - usersWeight:F0} кг." +
                    $"\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
            else if (index > indexOfDeficitWeight & index <= indexOfNormalWeight)
            {
                Console.WriteLine($"У Вас дефицит веса. Для номализации веса " +
                    $"Вам следует набрать {correctUsersWeight - usersWeight:F0} кг." +
                    $"\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
            else if (index >= indexOfNormalWeight - 1 & index <= indexOfNormalWeight + 1)
            {
                Console.WriteLine("У Вас нормальный вес. Коррекция  веса не требуется. " +
                    "\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
            else if (index > indexOfNormalWeight + 1 & index < indexOfOverWeight)
            {
                Console.WriteLine($"У Вас ожирение. Для номализации веса " +
                    $"Вам следует сбросить {usersWeight - correctUsersWeight:F0} кг." +
                    $"\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
            else if (index >= indexOfOverWeight)
            {
                Console.WriteLine($"У Вас сильное ожирение. Для номализации веса " +
                    $"Вам следует сбросить {usersWeight - correctUsersWeight:F0} кг." +
                    $"\nДля выхода нажмите любую клавишу.");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            MassCalc();
        }

        
    }
}
