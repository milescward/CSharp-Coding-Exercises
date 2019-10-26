namespace CSharp_Practice
{
    public class SelectionSort
    {
        public void SelectionSortM(int[] nums)
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

        public void SelectionSortRecursive(int[] arr, int startIndex)
        {
            int smallest = startIndex;
            for (int i = smallest + 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[smallest])
                {
                    smallest = i;
                }
                int temp = i;
                arr[i] = arr[smallest];
                arr[smallest] = temp;
            }
            if (startIndex + 1 < arr.Length-1)
            {
                SelectionSortRecursive(arr, startIndex + 1);
            }
        }

    }
}