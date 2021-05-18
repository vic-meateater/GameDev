using System;
namespace EX_1
{

    public class Tables
    {
        View view = new();
        public void Table(Fun F, double start, double end, double step)
        {
            //Console.WriteLine("Таблица функции MyFunc из методички:");
            for (double x = start; x < end; x += step)
            {
                view.Print($"| {x,20} | {F(x),-20} |");
            }
            view.Print(new String('-', 50));
        }
        public void Table(FunTwo F, double a, double start, double end, double step)
        {
            Console.WriteLine($"|------a-----|------x-----|----------F(x)--------|");
            for (double x = start; x < end; x += step)
            {
                view.Print($"| {a,10} | {x,10} | {F(a, x),-20} |");

            }
            view.Print(new String('-', 50));
        }
    }
}
