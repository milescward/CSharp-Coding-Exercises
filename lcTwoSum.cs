using System;
using System.Collections.Generic;

namespace Practice
{
    public class TwoSum
    {
        /*Given an array of integers, return indices of the two numbers 
        such that they add up to a specific target. You may assume that 
        each input would have exactly one solution, and you may not use 
        the same element twice. */

        // Brute force solution O(n^2)
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

        // Faster than 95% of solutions
        public int[] TwoSumFaster(int[] nums, int target) {
            var d = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var comp = target - nums[i];
                if (d.ContainsKey(comp))
                    return new int[] {d[comp], i};
                d[nums[i]] = i;
            }
            return null;
    }
    }
}