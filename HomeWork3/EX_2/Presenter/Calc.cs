using System;
using EX_2.View;
using EX_2.Models;

namespace EX_2.Presenter
{
    class Calc
    {
        Model model;
        ConsoleView view;
        public Calc(ConsoleView view)
        {
            this.view = view;
            model = new Model();
        }

        public void Sum()
        {
            int[] z = view.GetData();
            view.Print(model.SomeFunc(z).ToString());
        }
    }
}
