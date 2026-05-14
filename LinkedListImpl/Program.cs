ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

PrintList(head, "List");

int[] arr = new []{10, 20, 30, 40, 50};
ListNode? head2 = BuildNode(arr);


PrintList(head2, "Built from array");

ListNode? reverseHead2 = Reverse(head2);
PrintList(reverseHead2, "Reversed");

Console.WriteLine($"Middle (odd length): {FindMiddle(head)!.val}");

ListNode head3 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
Console.WriteLine($"Middle (even length): {FindMiddle(head3)!.val}");


Console.WriteLine($"Has cycle (acyclic list): {HasCycle(head)}");

ListNode? mid = head;

while(mid!.val != 3){
    mid = mid.next;
}
ListNode? curr = mid;
while(curr.next != null){
    curr = curr.next;
}
curr.next = mid;

Console.WriteLine($"Has cycle (cyclic list): {HasCycle(head)}");



static bool HasCycle(ListNode? head) {
    ListNode? slow = head, fast = head;

    while(fast != null && fast.next != null){
        slow = slow!.next;
        fast = fast.next.next;
        if(slow == fast)
            return true;
    }
    return false;
}

static ListNode? FindMiddle(ListNode? head) {
    ListNode? slow = head, fast = head;

    while(fast != null && fast.next != null){
        slow = slow!.next;
        fast = fast.next.next;
    }
    return slow;
}
static ListNode? Reverse(ListNode? head){
    ListNode? curr = head, prev = null;

    while(curr != null){
        var temp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = temp;
    }
    return prev;
}

static void PrintList(ListNode? head, string label){
    List<int> values = new();
    ListNode? curr = head;

    while(curr != null){
        values.Add(curr.val);
        curr = curr.next;
    }

    Console.WriteLine($"{label}: {string.Join(" -> ", values)}");
}


static ListNode? BuildNode(int[] values){
    ListNode? head = new(values[0]);
    ListNode? curr = head;
    for(int i =1; i< values.Length; i++){
        curr.next = new ListNode(values[i]);
        curr = curr.next;
    }
    return head;
}


public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null) {
        this.val = val;
        this.next = next;
    }
}