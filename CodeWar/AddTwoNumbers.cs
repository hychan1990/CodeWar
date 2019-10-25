using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWar
{
    
    ///Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class AddTwoNumbers
    {
        public ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode result = new ListNode(0);
            ListNode current = result;
            while (l1 != null || l2 != null)
            {
                int l1v = l1 != null ? l1.val : 0;
                int l2v = l2 != null ? l2.val : 0;
                current.val = l1v + l2v + carry;
                if (current.val >= 10)
                {
                    current.val -= 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
                if (l1 == null && l2 == null && carry == 0)
                {
                    return result;
                }
                current.next = new ListNode(carry);
                current = current.next;
            }
            return result;
        }
    }
}
