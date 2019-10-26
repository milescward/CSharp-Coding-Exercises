using System;

namespace CSharp_Practice
{
    public class lcSumOfSquareNumbers
    {
        public bool JudgeSquareSum(int c) 
        {
            for (double a = 0; a * a <= c; a++)
            {
                double b = (Math.Sqrt(c - a * a));
                if (b == (int) b)
                {
                    return true;
                }
            }
            return false;
        }
    }
}