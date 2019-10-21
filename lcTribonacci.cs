namespace CSharp_Practice
{
    public class lcTribonacci
    {
        /*The Tribonacci sequence Tn is defined as follows: 
        T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.
        Given n, return the value of Tn. */

        /*faster than 97.97% of C# submissions.
        Memory Usage: less than 100.00% of C#  submissions */
        public int Tribonacci(int n) {
        if (n == 0 || n == 1)
        {
            return n;
        }
        else if (n == 2)
        {
            return 1;
        }
        int n3 = 0;
        int n2 = 1;
        int n1 = 1;
        int newNum = 0;
        int i = 3;
        while(i <= n)
        {
           newNum = n3 + n2 + n1;
            n3 = n2;
            n2 = n1;
            n1 = newNum;
            i++; 
        }
        return newNum;
    }
    }
}