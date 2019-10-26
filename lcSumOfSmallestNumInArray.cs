using System;

namespace CSharp_Practice
{
    public class lcSumOfSmallestNumInArray
    {
        public int SumOfDigits(int[] A) {
            //loop through array to find smallest
            int smallest = A[0];
            foreach (var item in A)
            {
                if (item < smallest)
                    smallest = item;
            }
            //add
            int s = 0;
            while(smallest > 0)
            {
                s += smallest % 10;
                smallest /= 10;
            }
            if (s % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}