using System;
using System.Collections.Generic;

namespace CSharp_Practice
{
    /*Write an algorithm to determine if a number is "happy".

    A happy number is a number defined by the following process: 
    Starting with any positive integer, replace the number by the 
    sum of the squares of its digits, and repeat the process until 
    the number equals 1 (where it will stay), or it loops endlessly
     in a cycle which does not include 1. Those numbers for which 
     this process ends in 1 are happy numbers. */


    // O(log n) runtime
    // O(log n) space
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

        // O(log n) runtime
        // O(1) space
        public bool IsHappy2(int n) 
        {
            int slow = n;
            int fast = NextNum(n);
            while (slow != fast && fast != 1)
            {
                slow = NextNum(slow);
                fast = NextNum(NextNum(fast));
            }
            return fast == 1;
        }
    
    public int NextNum(int n)
    {
        double num = n;
        double sum = 0;
        while(num != 0)
        {
            sum += Math.Pow((num % 10), 2);
            num = Math.Floor(num / 10);
        }
        return (int)sum;
    }
    }
}