namespace CSharp_Practice
{
    public class MergeSort
    {
        public int[] MergeSrt(int[] nums)
        {
            //this is recursive, so its going to call itself
            //split into two arrays

            //declare length var and array vars
            int[] left;
            int[] right;
            int n = nums.Length;

            if (n % 2 == 0)
            {
                left = new int[n / 2];
                right = new int[n / 2];
            }
            else
            {
                left = new int[n / 2];
                right = new int[(n / 2) + 1];
            }


            //fill up each array

            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    left[i] = nums[i];
                }
                else
                {
                    right[i - n / 2] = nums[i];
                }
            }

            left = MergeSrt(left);
            right = MergeSrt(right);

            return Merge(left, right);
        }
        public int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int k = 0;
            int j = 0;
            int i = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[k] = left[i];
                    k++;
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    k++;
                    j++;
                }
            }
            while (i < left.Length)
            {
                result[k++] = left[i++];
            }
            while (j < right.Length)
            {
                result[k] = right[i];
                k++;
                i++;
            }
            return result;
        }
    }
}