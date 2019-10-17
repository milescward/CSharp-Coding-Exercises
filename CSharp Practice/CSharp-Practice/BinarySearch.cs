namespace CSharp_Practice
{
    public class BinarySearch
    {
        public int BinSearch(int[] nums, int target) {
            int n = nums.Length;
            int high = nums.Length;
            int low = 0;
            int middle = n / 2;
            if (nums[middle] == target)
            {
                return middle;
            }
            while (nums[middle] != target)
            {
                if (middle == low)
                {
                    break;
                }
                else if (nums[middle] > target)
                {
                    high = middle;
                    middle = (high + low) / 2;
                }
                else if (nums[middle] < target)
                {
                    low = middle;
                    middle = (high + low) / 2;
                }
                else
                {
                    return -1;
                }

            }
            if (nums[middle] == target)
            {
                return middle;
            }
            return -1;
    }
    }
}