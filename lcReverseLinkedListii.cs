namespace CSharp_Practice
{
    public class lcReverseLinkedListii
    {
        public ListNode ReverseBetween(ListNode head, int m, int n) {
        int count = 1;
        ListNode p1 = head;
        while (count != m)
        {
            p1 = p1.next;
            count++;
        }
        ListNode p2 = p1;
        while(count != n)
        {
            p2 = p2.next;
            count++;
        }
        int temp = p1.val;
        p1.val = p2.val;
        p2.val = temp;
        m++;
        n--;
        if (m < n)
            return ReverseBetween(head, m, n);
        else
            return head;
    }
    }
}