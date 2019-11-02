namespace CSharp_Practice
{
    /*Given an integer array nums, find the sum of the 
    elements between indices i and j (i ≤ j), inclusive. */
    public class NumArray {
    private int[] nums2;
    public NumArray(int[] nums) {
        nums2 = nums;
    }
    
    public int SumRange(int i, int j) {
        int sum = 0;
        for (int k = i; k <= j; k++)
        {
            sum += nums2[k];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */
}