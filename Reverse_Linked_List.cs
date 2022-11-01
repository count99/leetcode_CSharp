public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) { 
        this.val = val;
        this.next = next;
    }
}    
public class Solution {
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;
        while (current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        head = prev;
        return head;
    }

    public static void Main()
    {
        ListNode list = new ListNode(1);
        list.next = new ListNode(2);
        list.next.next = new ListNode(3);
        list.next.next.next = new ListNode(4);
        list.next.next.next.next = new ListNode(5);
        Solution test = new Solution();
        ListNode answer = test.ReverseList(list);
        while (answer!= null) {
            Console.Write(answer.val + " ");
            answer = answer.next;
        }
        Console.WriteLine();
    }
}