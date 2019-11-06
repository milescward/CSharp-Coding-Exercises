using System.Collections.Generic;
using System.Linq;

namespace CSharp_Practice.obj
{
    public class lcFindIntersection
    {
        public int[] Intersection(int[] nums1, int[] nums2) 
        {
            if (nums1.Length == 0 || nums2.Length == 0)
                return new int[0];
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            HashSet<int> set3 = new HashSet<int>();
            foreach (var item in nums1)
                set1.Add(item);
            foreach (var item in nums2)
                set2.Add(item);
            foreach (var item in set2)
            {
                if (set1.Add(item) == false)
                    set3.Add(item);
            }
            return set3.ToArray();
        }
    }
}