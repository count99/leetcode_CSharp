public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) { 
        this.val = val;
        this.next = next;
    }
}    
public class Solution {
    public ListNode DetectCycle(ListNode head)
    {
        int found = 0;
        ListNode slow = head;
        ListNode fast = head;
        ListNode aws = null;
        while (slow != null || fast != null)
        {
            try
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            catch
            {
                break;
            }
            if (slow == fast)
            {
                found = 1;
                break;
            }
        }
        if (found == 1)
        {
            slow = head;
            while (fast != slow)
            {
                slow = slow.next;
                fast = fast.next;
            }
            aws = slow;
        }

        return aws;
    }

    public static void Main()
    {
        ListNode list1 = new ListNode(3);
        list1.next = new ListNode(2);
        // list1.next.next = list1;
        // list1.next.next = new ListNode(0);
        // list1.next.next.next = new ListNode(-4);
        // list1.next.next.next.next = list1.next;
        
        Solution test = new Solution();
        ListNode answer = test.DetectCycle(list1);
        while (answer!= null) {
            Console.Write(answer.val + " ");
            answer = answer.next;
        }
        Console.WriteLine();
    }
}