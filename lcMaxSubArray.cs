namespace CSharp_Practice
{
    public class lcMaxSubArray
    {
        public int MaxSubArray(int[] nums) {
            if (nums.Length == 1)
                return nums[0];
            int largest =  int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                if (temp > largest)
                    {
                        largest = temp;
                    }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    temp += nums[j];
                    if (temp > largest)
                    {
                        largest = temp;
                    }
                }
            }
            return largest;
        }
    }
}