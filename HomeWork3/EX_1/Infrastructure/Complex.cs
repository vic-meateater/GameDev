namespace EX_1.Infrastructure
{
    public struct Complex
    {
        public double im;
        public double re;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }


        public string Print()
        {
            return re + "+" + im + "i";
        }
    }
}
