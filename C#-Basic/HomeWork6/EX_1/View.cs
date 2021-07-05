using System;
namespace EX_1
{
    public class View
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        public void GetFirst()
        {
            Tables tables = new();
            Functions functions = new();
            tables.Table(functions.MyFunc, -2, 2, 1);
        }
        public void GetSecond()
        {
            Tables tables = new();
            Functions functions = new();
            tables.Table(functions.MyFuncTwo, 2, -2, 2, 1);
        }
        public void GetThird()
        {
            Tables tables = new();
            Functions functions = new();
            tables.Table(functions.MyFuncThree, 2, -2, 2, 1);
        }
    }
}
