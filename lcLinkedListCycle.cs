namespace CSharp_Practice
{
    //Given a linked list, determine if it has a cycle in it.
    public class lcLinkedListCycle
    {
        public bool HasCycle(ListNode head) 
        {
            if (head == null || head.next == null)
                return false;
            else
            {
                ListNode slow = head;
                ListNode fast = head;
                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                    if (fast == slow)
                    {
                        return true;
                    }
                } 
                return false;
            }
        }
    }
}