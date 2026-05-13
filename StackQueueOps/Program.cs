

Console.WriteLine("--- Section 1: Stack basics ---");

Stack<int> stack = new();
stack.Push(10);
stack.Push(20);
stack.Push(30);
stack.Push(40);
stack.Push(50);

Console.WriteLine($"Stack contents: {string.Join(" ", stack)}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Popped: {stack.Pop()}");

Console.WriteLine($"After pop: {string.Join(" ", stack)}");

Console.WriteLine($"Count: {stack.Count}");



Console.WriteLine();
Console.WriteLine("--- Section 2: Queue basics ---");

Queue<string> queue = new();

queue.Enqueue("alice");
queue.Enqueue("bob");
queue.Enqueue("charlie");
queue.Enqueue("diana");

Console.WriteLine($"Queue contents: {string.Join(" ", queue)}");

Console.WriteLine($"Peek: {queue.Peek()}");
Console.WriteLine($"Dequeued: {queue.Dequeue()}");

Console.WriteLine($"After dequeue: {string.Join(" ", queue)}");

Console.WriteLine($"Count: {queue.Count}");



Console.WriteLine();
Console.WriteLine("--- Section 3: Balanced parentheses ---");

Dictionary<char, char> close = new();
close['}' ] = '{';
close[')'] = '(';
close[']'] = '[';

bool Isbalanced(string word){
    Stack<char> open = new();
    foreach(char c in word){
        if(close.ContainsKey(c)){
            if(open.Count == 0 || open.Pop() != close[c])
                return false;
        }
        else{
            open.Push(c);
        }
    }
    return open.Count == 0;
}

string word1 = "({[]})";
string word2 = "({[})";

Console.WriteLine($"\"{word1}\" balanced? {Isbalanced(word1)}");
Console.WriteLine($"\"{word2}\" balanced? {Isbalanced(word2)}");


Console.WriteLine();
Console.WriteLine("--- Section 4: Queue processing ---");

int[] arr = new[] { 5, 3, 8, 1, 9, 2 };
Queue<int> queue1 = new();

foreach (int i in arr)
    queue1.Enqueue(i);

while (queue1.Count > 0) {
    Console.WriteLine($"Processing: {queue1.Dequeue()}");
}


