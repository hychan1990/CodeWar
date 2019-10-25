using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWar
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(8);
            //ListNode l3 = new ListNode(3);
            l1.next = l2;
            //l2.next = l3;
            ListNode l4 = new ListNode(0);
            //ListNode l5 = new ListNode(7);
            //ListNode l6 = new ListNode(9);
            //l4.next = l5;
            //l5.next = l6;

            addTwoNumbers.AddTwoNumbersMethod(l1, l4);
        }
    }
}
