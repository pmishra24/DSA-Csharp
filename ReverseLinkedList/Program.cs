class Solution{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
   static void PrintList(ListNode head) {
        while (head != null) {
            Console.Write(head.val);
            if (head.next != null) Console.Write(" → ");
            head = head.next;
        }
        Console.WriteLine();
    }

    static ListNode ReverseList(ListNode head){
        ListNode? prev = null;
        ListNode curr = head;

        while(curr != null){
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        return prev;
    }

    public static void Main(string[] args) {
        // Build: 1 → 2 → 3 → 4 → 5
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        
        PrintList(head);
        var reversed = ReverseList(head);
        PrintList(reversed);
    }
}