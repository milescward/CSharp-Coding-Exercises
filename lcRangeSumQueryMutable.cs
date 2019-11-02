namespace CSharp_Practice
{
    /*
    Given an integer array nums, find the sum of the elements between 
    indices i and j (i ≤ j), inclusive.
    The update(i, val) function modifies nums by updating 
    the element at index i to val.
     */
    public class NumArray2 {
    
    private int[] nums2;
    public NumArray2(int[] nums) {
        nums2 = nums;
    }
    
    public void Update(int i, int val) {
        nums2[i] = val;
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
 * obj.Update(i,val);
 * int param_2 = obj.SumRange(i,j);
 */
}