using System;
/*Given an array of integers A sorted in 
non-decreasing order, return an array of 
the squares of each number, also in sorted 
non-decreasing order. */

/* Memory Usage: 39.1 MB, less than 100.00% 
of C# online submissions for Squares of a 
Sorted Array.*/
namespace CSharp_Practice
{
    public class lcSquaresOfASequence
    {
        public int[] SortedSquares(int[] A) {
        for(int i = 0; i < A.Length; i++)
        {
            A[i] = (int)Math.Pow(A[i], 2);
        }
        Array.Sort(A);
        return A;
    }
    }
}