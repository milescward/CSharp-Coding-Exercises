namespace CSharp_Practice
{
    public class BubbleSort
    {
         public void BubbleSrt(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < (nums.Length - 1) - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        // Searching through an array in linear time
        public void BubbleSrtBetter(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < (nums.Length - 1) - i; j++)
                {
                    bool swapped = false;
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        swapped = true;
                    }
                    if (!swapped)
                    {
                        return;
                    }
                }
            }
        }
    }
}