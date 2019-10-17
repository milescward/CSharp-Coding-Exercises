using System;

namespace Practice
{
    public class TwoSum
    {
        /*Given an array of integers, return indices of the two numbers 
        such that they add up to a specific target. You may assume that 
        each input would have exactly one solution, and you may not use 
        the same element twice. */

        public int[] FindTwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && (i != j))
                    {
                        result[0] = Math.Min(i, j);
                        result[1] = Math.Max(i, j); return result;
                    }
                }
            }

            return result;
        }
    }
}