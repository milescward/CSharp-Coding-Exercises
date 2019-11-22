using System;
using System.Collections.Generic;

namespace CSharp_Practice
{
    public class lcHappyNumber
    {
        public bool IsHappy(int n)
        {
            var hash = new HashSet<double>();
            double sum;
            double num = n;
            while (hash.Add(num))
            {
                sum = 0;
                while (num != 0.0)
                {
                    sum += Math.Pow((num % 10), 2);
                    num = Math.Floor(num / 10);
                }
                if (sum == 1)
                    return true;
                num = sum;
            }
            return false;
        }
    }
}