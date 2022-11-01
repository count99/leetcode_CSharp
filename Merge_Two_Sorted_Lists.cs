public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) { 
        this.val = val;
        this.next = next;
    }
}    
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode result = new ListNode();
        ListNode current = result;
        if (list1 == null && list2 == null)
        {
            result.next = null;
        }
        else
        {
            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    current.next = list2;
                    current = current.next;
                    break;
                }
                if (list2 == null)
                {
                    current.next = list1;
                    current = current.next;
                    break;
                }
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }
        }
        return result.next;
    }

    public static void Main()
    {
        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        ListNode list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(4);
        
        Solution test = new Solution();
        ListNode answer = test.MergeTwoLists(list1, list2);
        while (answer!= null) {
            Console.Write(answer.val + " ");
            answer = answer.next;
        }
        Console.WriteLine();
    }
}