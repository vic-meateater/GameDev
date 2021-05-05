using System;
using EX_1.View;
using EX_1.Models;
using EX_1.Infrastructure;

namespace EX_1.Presenter
{
    public class Calc
    {
        Model model;
        ConsoleView view;

        public Calc(ConsoleView view)
        {
            this.view = view;
            model = new Model();
        }

        public void Add()
        {
            Complex z1 = view.GetData();
            Complex z2 = view.GetData();

            view.Print(Model.Add(z1, z2).Print());
        }
        public void Multiply()
        {
            Complex z1 = view.GetData();
            Complex z2 = view.GetData();

            view.Print(Model.Multiply(z1, z2).Print());
        }
        public void Subtract()
        {
            Complex z1 = view.GetData();
            Complex z2 = view.GetData();

            view.Print(Model.Subtract(z1, z2).Print());
        }
    }
}
