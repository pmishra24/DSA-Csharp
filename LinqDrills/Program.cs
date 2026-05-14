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





Console.WriteLine();
Console.WriteLine("--- Part 7B: Sort, GroupBy, ToDictionary ---");




int[] nums = { 5, 2, 8, 1, 9, 3, 7, 4, 6 };

List<(string Name, int Age)> people = new() {
    ("alice", 30),
    ("bob", 25),
    ("charlie", 35),
    ("diana", 25),
    ("eve", 30)
};


Console.WriteLine($"OrderBy: {string.Join(" ", nums.OrderBy(x => x))}");
Console.WriteLine($"OrderByDescending: {string.Join(" ", nums.OrderByDescending(x => x))}");
Console.WriteLine($"Original nums unchanged: {string.Join(" ", nums)}");

Console.WriteLine($"By age: {string.Join(" ", people.OrderBy(x => x.Age).Select(y => $"{y.Name}({y.Age})"))}");
Console.WriteLine($"By age then name: {string.Join(" ", people.OrderBy(x => x.Age).ThenBy(z => z.Name).Select(y => $"{y.Name}({y.Age})"))}");
Console.WriteLine($"By age desc then name: {string.Join(" ", people.OrderByDescending(x => x.Age).ThenBy(z => z.Name).Select(y => $"{y.Name}({y.Age})"))}");


Console.WriteLine($"{string.Join("\n", people.GroupBy(x => x.Age).Select(y => $"Age {y.Key}: {string.Join(", ", y.Select(s => s.Name))}"))}");

var freq = "programming".GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

Console.WriteLine("Frequency of \"programming\":");

Console.WriteLine($"{string.Join("\n", freq.Select(y => $"{y.Key}: {y.Value}"))}");

var Freq = "programming".GroupBy(c => c).OrderByDescending(x => x.Count()).First();
Console.WriteLine($"Most frequent: {Freq.Key} (count: {Freq.Count()})");

var Freq2 = "programming".GroupBy(c => c).MaxBy(x => x.Count());
Console.WriteLine($"Most frequent (MaxBy): {Freq2.Key} (count: {Freq2.Count()})");


var peopleDict = people.ToDictionary(g => g.Name, g => g.Age);

Console.WriteLine("Name -> Age:");
Console.WriteLine($"{string.Join("\n", peopleDict.Select(y => $"{y.Key} -> {y.Value}"))}");


var peopleByPersonDict = people.ToDictionary(g => g.Name);
Console.WriteLine("Name -> Person:");
Console.WriteLine($"{string.Join("\n", peopleByPersonDict.Select(y => $"{y.Key} -> {y.Value}"))}");