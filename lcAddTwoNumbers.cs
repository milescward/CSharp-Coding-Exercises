namespace CSharp_Practice
{
    public class lcAddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            var dummy = new ListNode(-1);
            ListNode curr = dummy, p = l1, q = l2;
            int carry = 0, res = 0, pres = 0, qres = 0;
            while(p != null || q != null)
            {
                pres = (p==null)? 0 : p.val;
                qres = (q==null)? 0 : q.val;
                res = pres + qres + carry;
                carry = res / 10;
                curr.next = new ListNode(res % 10);
                curr = curr.next;
                if(p != null)
                    p = p.next;
                if(q != null)
                    q = q.next;
            }
            if(carry == 1)
                curr.next = new ListNode(carry);
            return dummy.next;
            
        }
    }
}