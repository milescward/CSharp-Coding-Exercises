namespace CSharp_Practice
{
    public class lcClimbingStairs
    {
        /*You are climbing a stair case. It takes n 
        steps to reach to the top. Each time you 
        can either climb 1 or 2 steps. In how many 
        distinct ways can you climb to the top? 
        Note: Given n will be a positive integer. */

        //faster than 99.5% of solutions
         public int ClimbStairs(int n) {
        if (n == 1 || n == 2)
        {
            return n;
        }
        int s2 = 2;
        int s1 = 1;
        int newNum = 0;
        int i = 3;
        while(i <= n)
        {
            newNum = s1 + s2;
            s1 = s2;
            s2 = newNum;
            i++;
        }
        return newNum;
    }
    }
}