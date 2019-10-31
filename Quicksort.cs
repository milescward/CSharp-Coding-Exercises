using System;

namespace CSharp_Practice
{
    public class Quicksort
    {
        public void QuickSort(int[] nums)
        {
            QuicksortHelper(nums, 0, nums.Length-1);
        }

        public void QuicksortHelper(int[] nums, int start, int end)
        {
            //only need to sort if there are at least two elements
            if (start < end)
            {
                //choose pivot
                int q = Partition(nums, start, end);
                QuicksortHelper(nums, start, q-1);
                QuicksortHelper(nums, q + 1, end);
            }
        }

        private int Partition(int[] nums, int start, int end)
        {
            // Choose last value as pivot
            int pivot = nums[nums.Length-1];
            int k = start - 1;
            for (int i = start; i < end; i++)
            {
                if (nums[i] < pivot)
                {
                    k++;
                    //swap
                    int tmp = nums[i];
                    nums[i] = nums[k];
                    nums[k] = tmp;
                }
            }

            //move the pivot
            k++;
            int temp = nums[end];
            nums[end] = nums[k];
            nums[k] = temp;

            return k + 1;
        }
    }
}