namespace CSharp_Practice
{
    public class MergeSort
    {
        // This portion of the 
        public int[] Sort(int[] arr) {
            // Get the length and middle of the array
            int len = arr.Length, m = len / 2;
            // If the array has a single element, return it.
            if(len < 2) return arr;
            // Create two new arrays right and left from the
            // given array split down the middle
            int[] left = new int[m], right = new int[len - m];
            // Fill the new arrays with the elements from the original array
            for (int i = 0; i < m; i++){
                left[i] = arr[i];}
            for (int i = 0; m < len; i++) {
                right[i] = arr[m++];}
            // Recursively break the smaller arrays down until they're
            // all the size of just one single array.
            Sort(left); Sort(right);
            // Sort the two given arrays into the original given array
            return Merge(left, right, arr);}

        private int[] Merge(int[] l, int[] r, int[] a) {
            // Create pointers for each array l, r, and a
            int lp = 0, rp = 0, ap = 0;
            // Fill the given array a with the elements from arrays l and
            // r in ascending order until one of the arrays l and r
            // is exhausted.
            while (lp < l.Length && rp < r.Length)
                a[ap++] = (l[lp] <= r[rp])? l[lp++] : r[rp++];
            // Once the original while loop exits, fill up array a
            // with the remaining elements from either array l or r
            // Only one of these will execute
            while (lp < l.Length)
                a[ap++] = l[lp++];
            while (rp < r.Length)
                a[ap++] = r[rp++]; return a;} 
    }
}