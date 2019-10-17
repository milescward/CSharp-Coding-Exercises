using System;

namespace CSharp_Practice
{
    public class SingleNum
    {
        public int SingleNumber(int[] nums)
        {

            //sort the array
            Array.Sort(nums);
            //loop through the array
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
                i++;
            }
            return nums[nums.Length - 1];
        }
    }
}