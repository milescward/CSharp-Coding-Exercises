namespace CSharp_Practice
{
    public class SelectionSort
    {
        public void SelectedSort(int[] nums)
        {
            int smallest;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < smallest)
                    {
                        smallest = j;
                    }
                }
                int temp = i;
                nums[i] = nums[smallest];
                nums[smallest] = temp;
            }
        }
    }
}