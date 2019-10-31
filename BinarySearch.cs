namespace CSharp_Practice
{
    public class BinarySearch
    {
        /* Given a sorted (in ascending order) integer 
        array nums of n elements and a target value, 
        write a function to search target in nums. If 
        target exists, then return its index, otherwise 
        return -1. 
        */

        public int BinSearch2(int[] arr, int target)
        {
            int l = 0;
            int r = arr.Length -1;
            int middle = (l + r) / 2;
            while (l <= r)
            {
                if (arr[middle] ==  target)
                    return middle;
                else if (arr[middle] > target)
                    r = middle - 1;
                else
                    l = middle + 1;
                middle = (l + r) / 2;
            }
            return -1;
        }
    }
}