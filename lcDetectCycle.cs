using System.Collections.Generic;

namespace CSharp_Practice
{
    /*Given a linked list, return the node where the cycle begins. 
    If there is no cycle, return null. To represent a cycle in 
    the given linked list, we use an integer pos which 
    represents the position (0-indexed) in the linked list where 
    the tail connects to. If pos is -1, then there is no cycle in 
    the linked list.

    Note: Do not modify the linked list. */

    // Faster than 97% of submissions
    public class lcDetectCycle
    {
        public ListNode DetectCycle(ListNode head) {
        ListNode slow = head;
        var hs = new HashSet<ListNode>();
        while (slow != null){
            if (!hs.Add(slow)) return slow;
            slow = slow.next;
        } 
        return slow;
    }
    }
}