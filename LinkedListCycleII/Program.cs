class Solution{

    public class ListNode {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null) {
            this.val = val;
            this.next = next;
        }
    }

    

    public static ListNode? DetectCycle(ListNode? head) {
        HashSet<ListNode> seenNodes = new();

        ListNode? temp = head;
        while(temp != null){
            if(!seenNodes.Add(temp)){
                return temp;
            }
            temp = temp.next;
        }
        return null;
    }

    public static ListNode? DetectCycle2(ListNode? head) {
        if (head == null || head.next == null) return null;
        
        ListNode? slow = head;
        ListNode? fast = head;
        
        // Phase 1: detect cycle
        while (fast?.next != null) {
            slow = slow!.next;
            fast = fast.next.next;
            if (slow == fast) break;
        }
        
        // No cycle
        if (fast == null || fast.next == null) return null;
        
        // Phase 2: find cycle start
        slow = head;
        while (slow != fast) {
            slow = slow!.next;
            fast = fast!.next;
        }
        
        return slow;
    }
   

    public static void Main(string[] args) {
        // Build: 3 → 2 → 0 → -4, with -4's next pointing back to 2
        var node2 = new ListNode(2);
        var node0 = new ListNode(0);
        var nodeMinus4 = new ListNode(-4);
        var head = new ListNode(3, node2);
        node2.next = node0;
        node0.next = nodeMinus4;
        nodeMinus4.next = node2;   // creates the cycle

        var result = DetectCycle2(head);
        Console.WriteLine(result == null ? "null" : result.val.ToString());  // expects 2

        var headNoCycle = new ListNode(1, new ListNode(2, new ListNode(3)));
        var result2 = DetectCycle(headNoCycle);
        Console.WriteLine(result2 == null ? "null" : result2.val.ToString()); 
    }
}