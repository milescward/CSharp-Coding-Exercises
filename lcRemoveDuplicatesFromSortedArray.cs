namespace CSharp_Practice
{
    /* Given a sorted array nums, remove the duplicates 
    in-place such that each element appear only once 
    and return the new length.

    Do not allocate extra space for another array, you must
    do this by modifying the input array in-place with 
    O(1) extra memory.
     */
    public class lcRemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums == null)
                return 0;
            int ph = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[ph] != nums[i])
                {
                    ph++;
                    nums[ph] = nums[i];
                }
            }
            return ph + 1;
        }
    }
}