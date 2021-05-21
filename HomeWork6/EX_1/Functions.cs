using System;
namespace EX_1
{
    public class Functions
    {
        public double MyFunc(double x)
        {
            return x * x * x;
        }

        public double MyFuncTwo(double a, double x)
        {
            return a * (x * x);
        }

        public double MyFuncThree(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
