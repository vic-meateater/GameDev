using EX_1.Models;
using EX_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1.Presenter
{
    class Massivius
    {
        Devider devider;
        ConsoleView view;
        public Massivius(ConsoleView view)
        {
            this.view = view;
            devider = new Devider();
        }

        public void Devider()
        {
            int[] z = view.GetData();
            view.SomePrint(devider.DevideFromArray(z[0], z[1]).ToString());
        }
        public void DeviderFromFile()
        {
            int[] z = view.GetDataFromFile();
            view.SomePrint(devider.DevideFromFile(z).ToString());
        }

        public void MyArrayPrint()
        {
            Dictionary<string, int> arrayData = view.GetArrayData();
            MyArrays myArray = new(arrayData["size"], arrayData["minValue"], arrayData["maxValue"]);
            view.SomePrint(myArray.Sum().ToString());
            myArray.Inverse();
            int z = view.GetInt();
            myArray.Multi(z);
        }
    }
}
