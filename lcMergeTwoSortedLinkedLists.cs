namespace CSharp_Practice
{
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    public class lcMergeTwoSortedLinkedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
    {
        if (l1 == null)
            return l2;
        else if(l2 == null)
            return l1;
        var p1 = l1.next;
        var p2 = l2.next;
        if (l1.val <= l2.val)
        {
            l1.next = MergeTwoLists(p1, l2);
            return l1;
        }
        
        l2.next = MergeTwoLists(p2, l1);
        return l2;
    }
    }
}