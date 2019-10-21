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
        public int Fib(int N) {
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
    }
}