int[] arr1 = { 1, 2, 3, 4, 5 };

for(int i =0, j = arr1.Length - 1; i < j; i++, j--){
    (arr1[i], arr1[j]) = (arr1[j], arr1[i]);
}

Console.WriteLine($"Reversed: {string.Join(" ", arr1)}");


string word1 = "racecar";
string word2 = "hello";

Console.WriteLine($"\"{word1}\" palindrome: {IsPalindrome(word1)}");
Console.WriteLine($"\"{word2}\" palindrome: {IsPalindrome(word2)}");


int[] sorted = { 1, 3, 5, 7, 9, 11, 15 };
int target = 14;

int[] res = TwoSumSorted(sorted, target);

Console.WriteLine($"Two sum target {target}: {res[0]} {res[1]}");

target = 100;
res = TwoSumSorted(sorted, target);
Console.WriteLine($"Two sum target {target}: {res[0]} {res[1]}");

int[] dups = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };

int unique = RemoveDuplicates(dups);
Console.WriteLine($"Unique count: {unique}");
Console.WriteLine($"Unique values: {string.Join(" ", dups.Take(unique))}");

int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
Console.WriteLine($"Max area: {MaxArea(heights)}");


int MaxArea(int[] h) {
    int left = 0, right = h.Length - 1;
    int maxArea = 0;
    while (left < right) {
        int area = Math.Min(h[left], h[right]) * (right - left);
        maxArea = Math.Max(maxArea, area);
        if (h[left] < h[right]) left++;
        else right--;
    }
    return maxArea;
}



static int RemoveDuplicates(int[] arr){
    int i =0;
    for(int j = 1;  j < arr.Length; j++){
       if(arr[i] != arr[j]){
            i++;
            arr[i] = arr[j];
       }
    }
    return i + 1;
}




static int[] TwoSumSorted(int[] sorted, int target){
    for(int i =0, j = sorted.Length - 1; i < j;){
        if(sorted[i] + sorted[j] < target)
            i++;
        else if(sorted[i] + sorted[j] > target)
            j--;
        else{
            return new[] {i, j};
        }
    }
    return new[] {-1, -1};
}

static bool IsPalindrome(string word){
    for(int i =0, j = word.Length - 1; i < j; i++, j--){
        if(word[i] != word[j])
            return false;
    }
    return true;
} 


// Reversed: 5 4 3 2 1
// "racecar" palindrome: True
// "hello" palindrome: False
// Two sum target 14: 2 4
// Two sum target 100: -1 -1
// Unique count: 5
// Unique values: 1 2 3 4 5
// Max area: 49