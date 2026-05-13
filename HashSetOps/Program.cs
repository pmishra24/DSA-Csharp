
Console.WriteLine("--- Section 1: Basic operations ---");

HashSet<int> set = new (){1, 2, 3, 4, 5};
Console.WriteLine($"Initial set: {string.Join(" ", set)}");

Console.WriteLine($"Add 3 again — added: {set.Add(3)}");

Console.WriteLine($"Contains 4: {set.Contains(4)}");

set.Remove(2);
Console.WriteLine($"After removing 2: {string.Join(" ", set)}");

Console.WriteLine($"Count: {set.Count}");

HashSet<int> set1 = new (){4,5,6,7,8};
Console.WriteLine($"Second set: {string.Join(" ", set1)}");

Console.WriteLine();
Console.WriteLine("--- Section 2: Set operations ---");

HashSet<int> unionSet = new (set);
unionSet.UnionWith(set1);
Console.WriteLine($"Union: {string.Join(" ", unionSet)}");

HashSet<int> intersectionSet = new (set);
intersectionSet.IntersectWith(set1);
Console.WriteLine($"Intersect: {string.Join(" ", intersectionSet)}");

HashSet<int> differenceSet = new (set);
differenceSet.ExceptWith(set1);
Console.WriteLine($"Difference (A - B): {string.Join(" ", differenceSet)}");


Console.WriteLine();
Console.WriteLine("--- Section 3: Duplicate detection ---");

int[] arr = new int[]{1, 5, 3, 7, 5, 9, 3, 2};
HashSet<int> seen = new ();

foreach (int i in arr){
    if(seen.Contains(i)){
        Console.WriteLine($"First duplicate: {i}");
            break;
    }
    seen.Add(i);
}

seen = new(arr);
Console.WriteLine($"Has duplicates: {arr.Length != seen.Count}");




Console.WriteLine();
Console.WriteLine("--- Section 4: Convert between collections ---");

List<int> list = new() { 1, 2, 2, 3, 3, 3, 4 };

HashSet<int> uniqueList = new(list);
Console.WriteLine($"Unique from list: {string.Join(" ", uniqueList)}");

Console.WriteLine($"Back to list: {string.Join(" ", uniqueList.ToList())}");



