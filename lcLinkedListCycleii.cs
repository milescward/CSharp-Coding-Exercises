using System.Collections.Generic;

namespace CSharp_Practice
{
    public class lcLinkedListCycleii
    {
        public ListNode DetectCycle(ListNode head) 
        {
            if (head == null || head.next == null)
                return null;
            ListNode slow = head;
            var myHash = new HashSet<ListNode>();
            while (myHash.Add(slow) != false)
            {
                if (slow.next == null)
                    return null;
                slow = slow.next;
            } 
            return slow;
        }
    }
}