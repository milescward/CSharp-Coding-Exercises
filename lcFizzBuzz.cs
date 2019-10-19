using System;
using System.Collections.Generic;

namespace CSharp_Practice
{
    public class FizzBuzz
    {
        public IList<string> FizzBuzzMethod(int n) 
        {
            List<string> lst = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    lst.Add("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    lst.Add("Buzz");
                }
                else if (i % 3 == 0)
                {
                    lst.Add("Fizz");
                }
                else
                {
                    lst.Add(Convert.ToString(i));
                }
            }
            return lst;
        }
    }
}