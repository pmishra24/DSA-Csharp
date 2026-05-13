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