using System.Collections.Generic;

namespace CSharp_Practice
{
    public class lcPalindromeLinkedList
    {
        
    }

    //Definition for singly-linked list.
    // public class ListNode 
    // {
    //     public int val;
    //     public ListNode next;
    //     public ListNode(int x) 
    //     { 
    //         this.val = x; 
    //     }
    // }

public class Solution {
    public bool IsPalindrome(ListNode head) {
       if (head == null || head.next == null)
        {
            return true;
        }
        else
        {
            Stack<int> stack = new Stack<int>();
            ListNode pointer = head;
            while (pointer != null)
            {
                stack.Push(pointer.val);
                pointer = pointer.next;
            }
            pointer = head;
            while (pointer.next != null)
            {
                if (stack.Pop() != pointer.val)
                {
                    return false;
                }
                pointer = pointer.next;
            }
            return true;
        }
    }
}
}