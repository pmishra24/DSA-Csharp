Console.WriteLine("--- Section 1: Basic operations ---");
Dictionary<string, int> dict = new();

dict.Add("apple", 50);
dict.Add("banana", 20);
dict.Add("cherry", 30);
dict.Add("date", 80);



Console.WriteLine("All entries: ");
foreach(string s in dict.Keys){
    dict.TryGetValue(s, out int val);
    Console.WriteLine($"{s}: {val}");
}

dict.TryGetValue("banana", out int val1);
Console.WriteLine($"Value of banana: {val1}");

Console.WriteLine($"Contains mango: {dict.ContainsKey("mango")}");

dict["apple"] = 100;

dict.TryGetValue("apple", out val1);
Console.WriteLine($"Updated apple : {val1}");

dict.Remove("date");

Console.WriteLine("After removing date:");
foreach(var keyValuePairs in dict)
    Console.WriteLine($"{keyValuePairs.Key}: {keyValuePairs.Value}");

Console.WriteLine($"Count: {dict.Count}");

Console.WriteLine();
Console.WriteLine("--- Section 2: Safe lookup ---");

if(dict.TryGetValue("mango", out val1))
    Console.WriteLine($"TryGetValue mango: {val1}");
else
    Console.WriteLine("TryGetValue mango: not found");

if(dict.ContainsKey("cherry"))
    Console.WriteLine($"ContainsKey check — cherry: {dict["cherry"]}");
else
    Console.WriteLine("cherry not found");

Console.WriteLine($"GetValueOrDefault grape (fallback -1): {dict.GetValueOrDefault("grape", -1)}");

Console.WriteLine();
Console.WriteLine("--- Section 3: Frequency counter ---");

string word = "programming";
Dictionary<char, int> freqCount = new();

foreach(char c in word){
    freqCount[c] = freqCount.GetValueOrDefault(c, 0) + 1;
}

foreach(var keyValuePairs in freqCount)
    Console.WriteLine($"{keyValuePairs.Key}: {keyValuePairs.Value}");

var mostFreq  = freqCount.OrderByDescending(kvp => kvp.Value).First();
Console.WriteLine($"Most frequent: {mostFreq.Key} with count {mostFreq.Value}");

Console.WriteLine();
Console.WriteLine("--- Section 4: Iteration patterns ---");

Console.WriteLine("foreach kvp:");

Console.WriteLine(string.Join(", ", freqCount.Select(kvp => $"{kvp.Key}={kvp.Value}")));

Console.WriteLine($"Keys: {string.Join(" ", freqCount.Keys)}");
Console.WriteLine($"Values: {string.Join(" ", freqCount.Values)}");