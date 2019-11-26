namespace CSharp_Practice
{
    // Given an array, rotate the array to the 
    // right by k steps, where k is non-negative.
    public class lcRotateArrayKTimes
    {
        public void Rotate(int[] nums, int k) 
        {
            k %= nums.Length;
            if (k == 0)
                return;
            nums = Reverse(nums, 0, nums.Length - 1);
            nums = Reverse(nums, 0, k-1);
            nums = Reverse(nums, k, nums.Length - 1);
        }
    
        public int[] Reverse(int[] arr, int l, int r)
        {
            int temp;
            while (l < r)
            {
                temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }
            return arr;
        }
    }
}