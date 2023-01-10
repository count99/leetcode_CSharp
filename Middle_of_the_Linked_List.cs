using System;
/*You are given two non-empty linked lists representing two non-negative integers. 
 * The digits are stored in reverse order and each of their nodes contain a single digit. 
 * Add the two numbers and return it as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.
Example:
Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
 * */
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    } 
}

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        int count = 0;
        ListNode temp = head;
        while (temp != null)
        {
            count += 1;
            temp = temp.next;
        }
        temp = head;
        count = Convert.ToInt16(Math.Floor(Convert.ToDecimal(count) / 2));
        for (int i = 0; i<count; i++)
        {
            temp = temp.next;
        }

        return temp;
    }

    public static void Main()
    {
        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(2);
        l1.next.next = new ListNode(3);
        l1.next.next.next = new ListNode(4);
        l1.next.next.next.next = new ListNode(5);
        l1.next.next.next.next.next = new ListNode(6);
        // l1.next.next.next.next.next.next = new ListNode(9);

        // ListNode l2 = new ListNode(9);
        // l2.next = new ListNode(9);
        // l2.next.next = new ListNode(9);
        // l1.next.next.next = new ListNode(9);

        Solution test = new Solution();
        ListNode list = test.MiddleNode(l1);
        while (list != null)
        {
            Console.WriteLine(list.val);
            list = list.next;
        }
    }
}