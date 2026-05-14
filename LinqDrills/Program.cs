using System.Linq;

Console.WriteLine("--- Part 7A: Filter, Transform, Aggregate ---");

int[] arr = { 5, 12, 3, 18, 7, 24, 9, 16, 1, 30 };

Console.WriteLine($"Greater than 10: {string.Join(" ", arr.Where(x => x>10))}");
Console.WriteLine($"Even numbers: {string.Join(" ", arr.Where(x => x%2 == 0))}");
Console.WriteLine($"Squared:  {string.Join(" ", arr.Select(x => x*x))}");
Console.WriteLine($"Squared (>10 only):  {string.Join(" ", arr.Where(x => x > 10).Select(x => x * x))}");
Console.WriteLine($"Odd count: {arr.Count(x => x%2 != 0)}");
Console.WriteLine($"Sum: {arr.Sum()}");
Console.WriteLine($"Sum of evens: {arr.Where(x => x%2 == 0).Sum()}");
Console.WriteLine($"Max: {arr.Max()}");
Console.WriteLine($"Min: {arr.Min()}");
Console.WriteLine($"Average: {arr.Average()}");
Console.WriteLine($"Doubled list: {string.Join(" ", arr.Select(x => x*2))}");
Console.WriteLine($"Filtered array: {string.Join(" ", arr.Where(x => x>10).ToArray())}");



List<string> words = new() { "apple", "banana", "apple", "cherry", "banana", "apple", "date", "banana" };



// Console.WriteLine($"Once: {string.Join(" ", words.GroupBy(w => w).Where(x => x.Count() == 1).Select(y => y.Key))}");
// Dictionary<string, int> freqMap = new();
// // freqMap = words.GroupBy(w => w);

// Console.WriteLine($"Freq Map: {string.Join(" ", words.GroupBy(w => w).Select(kvp => $"{kvp.Key} -> {kvp.Count()}"))}");
// int highestCount = words.GroupBy(w => w).MaxBy(x => x.Count()).Count();
// Console.WriteLine($"Highest Count{highestCount}: {words.GroupBy(w => w).MaxBy(x => x.Count()).Key}");

// Console.WriteLine($"All Highest Count{highestCount}: {string.Join( " ", words.GroupBy(w => w).Where(x => x.Count() == highestCount).Select(y => y.Key))}");


HashSet<string> unique = new(words);
Console.WriteLine($"Unique words: {string.Join(" ", unique)}");

Dictionary<string, int> freqMap = new();

foreach(string word in words){
    freqMap[word] = freqMap.GetValueOrDefault(word, 0) + 1;
}

foreach(var kvp in freqMap){
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}
int highestCount = freqMap.OrderByDescending(x=> x.Value).First().Value;
Console.WriteLine($"Most frequent: {string.Join("\n", freqMap.Where(x=> x.Value == highestCount).Select(y => $"{y.Key} (count: {y.Value})"))}");

Console.WriteLine($"Words appearing once: {string.Join(" ", freqMap.Where(x=> x.Value == 1).Select(kvp => kvp.Key))}");
