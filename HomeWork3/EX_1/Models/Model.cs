using System;
using EX_1.Infrastructure;

namespace EX_1.Models
{
    public class Model
    {
        public static Complex Add(Complex x, Complex y)
        {
            Complex result = new Complex();
            result.re = x.re + y.re;
            result.im = x.im + y.im;
            return result;
        }
        public static Complex Subtract(Complex x, Complex y)
        {
            Complex result = new Complex();
            result.re = x.re - y.re;
            result.im = x.im - y.im;
            return result;
        }
        public static Complex Multiply(Complex x, Complex y)
        {
            Complex result = new Complex();
            result.im = y.re * x.im + y.im * x.re;
            result.re = y.re * x.re - y.im * x.im;
            return result;
        }
    }
}
