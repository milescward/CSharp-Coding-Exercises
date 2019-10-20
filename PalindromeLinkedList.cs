using System;

namespace CSharp_Practice
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head) 
        {
            ListNode pointer1 = head;
            decimal length = 1;
            while (pointer1.next != null)
            {
                length++;
                pointer1 = pointer1.next;
            }
            if (length == 2 && head != head.next)
            {
                return false;
            }
            pointer1 = head;

            ListNode pointer2 = head;
            int i = 1;       
            while (i <= Math.Ceiling(length/2))
            {
                pointer2 = pointer2.next;
                i++;
            }
            ListNode midpoint = pointer2;
            while (pointer1 != midpoint && pointer2.next != null)
            {
                if (pointer1.val != pointer2.val)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class ListNode {
       public int val;
       public ListNode next;
       public ListNode(int x) { val = x; }
  }
}