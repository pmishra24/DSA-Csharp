List<int> list = new ();
list.Add(10);
list.Add(20);
list.Add(30);
list.Add(40);
list.Add(50);
Console.WriteLine($"After Add: {string.Join(" ", list)}");

list.AddRange(new[] {60, 70, 80});
Console.WriteLine($"After AddRange: {string.Join(" ", list)}");

list.Insert(2, 25);
Console.WriteLine($"After Insert 25 at index 2: {string.Join(" ", list)}");

list.Remove(40);
Console.WriteLine($"After Remove 40: {string.Join(" ", list)}");

list.RemoveAt(0);
Console.WriteLine($"After RemoveAt 0: {string.Join(" ", list)}");

Console.WriteLine($"Contains 25: {list.Contains(25)}");

Console.WriteLine($"IndexOf 70: {list.IndexOf(70)}");

Console.WriteLine($"Count: {list.Count}");

list.Sort();
Console.WriteLine($"Sorted Asc: {string.Join(" ", list)}");

list.Sort((a, b) => b - a);
Console.WriteLine($"Sorted Desc: {string.Join(" ", list)}");

list.Reverse();
Console.WriteLine($"Reversed: {string.Join(" ", list)}");

int[] arr = list.ToArray();
Console.WriteLine($"As Array: {string.Join(" ", arr)}");

List<string> fruits = new (){"apple", "banana", "cherry"};
Console.WriteLine($"Fruits: {string.Join(" ", fruits)}");