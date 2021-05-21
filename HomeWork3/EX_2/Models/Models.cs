using System;
namespace EX_2.Models
{
    public class Model
    {
        public int SomeFunc(int[] someArray)
        {
            int sum = 0;
            foreach(int num in someArray)
            {
                sum += num;
            }
            return sum;
        }
    }
}
