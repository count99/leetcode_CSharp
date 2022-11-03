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
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode now_object = new ListNode(0);
        ListNode operate_object = now_object;
        int carry = 0;
        int remainder = 0;
        while (l1 != null || l2 != null)
        {
            int sum = 0;
            if (l1 != null) { sum += l1.val; }
            if (l2 != null) { sum += l2.val; }
            if (carry > 0)
            {
                sum += carry;
                carry = sum / 10;
                remainder = sum % 10;
            }
            else
            {
                carry = sum / 10;
                remainder = sum % 10;
            }
            if (l1 != null) { l1 = l1.next; }
            if (l2 != null) { l2 = l2.next; }
            operate_object.next = new ListNode(remainder);
            operate_object = operate_object.next;
        }
        if (carry > 0)
        {
            operate_object.next = new ListNode(carry);
        }
        return now_object.next;
    }

    public static void Main()
    {
        ListNode l1 = new ListNode(9);
        l1.next = new ListNode(9);
        l1.next.next = new ListNode(9);
        l1.next.next.next = new ListNode(9);
        l1.next.next.next.next = new ListNode(9);
        l1.next.next.next.next.next = new ListNode(9);
        l1.next.next.next.next.next.next = new ListNode(9);

        ListNode l2 = new ListNode(9);
        l2.next = new ListNode(9);
        l2.next.next = new ListNode(9);
        l1.next.next.next = new ListNode(9);

        ListNode list = AddTwoNumbers(l1, l2);
        while (list != null)
        {
            Console.WriteLine(list.val);
            list = list.next;
        }
    }
}