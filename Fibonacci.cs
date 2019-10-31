using System;
using System.Collections.Generic;

namespace CSharp_Practice
{
    public class Fibonacci
    {

        /*The Fibonacci numbers, commonly denoted F(n) 
        form a sequence, called the Fibonacci sequence, 
        such that each number is the sum of the two 
        preceding ones, starting from 0 and 1. That is,

        F(0) = 0,   F(1) = 1
        F(N) = F(N - 1) + F(N - 2), for N > 1.
        Given N, calculate F(N). */

        //this soltuion runs faster than 99.3% of 
        //submissions
        public int Fib(int N) 
        {
            if (N == 0 || N == 1)
            {
                return N;
            }
            int n2 = 0;
            int n1 = 1;
            int newNum = 0;
            int i = 2;
            while(i <= N)
            {
            newNum = n2 + n1;
                n2 = n1;
                n1 = newNum;
                i++; 
            }
            return newNum;
        }

        public int fib2(int n)
        {
            if (n < 0)
            {
                throw new Exception("Should be positive");
            }
            else if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fib2(n-1) + fib2(n-2);
            }
        }

        public Dictionary<int,int> d = new Dictionary<int, int>();
        public int fibMemoization(int n)
        {
            if (d.ContainsKey(n))
            {
                return d[n];
            }
            else
            {
                if (n < 0)
                {
                    throw new Exception("Should be positive");
                }
                else if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }
                else
                {
                    int ret = fib2(n-1) + fib2(n-2);
                    d[n] = ret;
                    return ret;
                }
            }
        }
    }
}