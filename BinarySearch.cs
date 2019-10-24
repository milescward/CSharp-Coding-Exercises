namespace CSharp_Practice
{
    public class BinarySearch
    {
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