namespace CSharp_Practice
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k) {
        int[] arr = new int[nums.Length];
        nums.CopyTo(arr, k+1);
        int j = 0;
        for(int i = nums.Length-k; i <= k; i++)
        {
            arr[j] = nums[i];
            j++;
        }
    }
    }
}