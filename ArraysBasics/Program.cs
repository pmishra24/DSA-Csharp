int[] arr = new int[]{5, 2, 8, 1, 9, 3, 7, 4, 6};


Console.WriteLine($"Original: {string.Join(" ", arr)}");
Console.WriteLine("Length: " + arr.Length);

Array.Sort(arr);

Console.WriteLine($"Sorted Asc: {string.Join(" ", arr)}");
Array.Sort(arr, (a, b) => b - a);

Console.WriteLine($"Sorted Desc: {string.Join(" ", arr)}");

Array.Reverse(arr);

Console.WriteLine($"Reversed: {string.Join(" ", arr)}");
Console.WriteLine("Index of 7 is " + Array.IndexOf(arr, 7));
Console.WriteLine("Sum of Array is " + arr.Sum());
Console.WriteLine("Min of Array is " + arr.Min());
Console.WriteLine("Max of Array is " + arr.Max());
Console.WriteLine("Average of Array is " + arr.Average());

int[] arr1 = new int[5];
Array.Fill(arr1, 0);

Console.Write($"New array of size 5 and filled with 0: {string.Join(" ", arr1)}");



