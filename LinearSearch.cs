namespace CSharp_Practice
{
    public class LinearSearch
    {
        public int LinearSearchMethod(int[] arr, int value)
        {
            foreach (var item in arr)
            {
                int idx = -1;
                for (int i = 0; i < arr.Length && idx == -1; i++)
                {
                    if(arr[i] == value)
                        idx = i;
                }
            }
            return -1;
        }
    }
}