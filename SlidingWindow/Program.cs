
int[] arr1 = { 2, 1, 5, 1, 3, 2 };
int k1 = 3;

Console.WriteLine($"Max sum of {k1} consecutive: {MaxSumK(arr1, k1)}");

string s1 = "abcabcbb";
Console.WriteLine($"Longest unique substring of \"abcabcbb\": {LongestUniqueSubstring(s1)}");
Console.WriteLine($"Longest unique substring of \"bbbbb\": {LongestUniqueSubstring("bbbbb")}");
Console.WriteLine($"Longest unique substring of \"pwwkew\": {LongestUniqueSubstring("pwwkew")}");
Console.WriteLine($"Longest unique substring of \"abc\": {LongestUniqueSubstring("abc")}");    
Console.WriteLine($"Longest unique substring of \"\": {LongestUniqueSubstring("")}");     


int[] arr3 = { 2, 3, 1, 2, 4, 3 };
int target3 = 7;

Console.WriteLine($"Smallest subarray with sum ≥ 7: {SmallestSubarrayWithSum(arr3, target3)}");
Console.WriteLine($"Smallest subarray with sum ≥ 100: {SmallestSubarrayWithSum(arr3, 100)}");

Console.WriteLine($"Longest with at most 2 distinct in \"eceba\": {LongestSubstringKDistinct("eceba", 2)}");


int LongestSubstringKDistinct(string s, int k) {
    int left = 0;
    Dictionary<char, int> freq = new();
    int maxLen = 0;

    for(int right = 0; right < s.Length; right++){
        freq[s[right]] = freq.GetValueOrDefault(s[right], 0) + 1;
        while(freq.Count > k){
            freq[s[left]]--;
            if (freq[s[left]] == 0) freq.Remove(s[left]);
            left++;
        }
        maxLen = Math.Max(maxLen, right - left + 1);
    }
    return maxLen;
}

int SmallestSubarrayWithSum(int[] arr, int target) {
    int left = 0, windowSum = 0, minLen = int.MaxValue;
    for (int right = 0; right < arr.Length; right++) {
        windowSum += arr[right];
        while (windowSum >= target) {
            minLen = Math.Min(minLen, right - left + 1);
            windowSum -= arr[left];
            left++;
        }
    }
    return minLen == int.MaxValue ? 0 : minLen;
}

static int LongestUniqueSubstring(string s) {
    HashSet<char> window = new();
    int left = 0, maxLen = 0;
    for (int right = 0; right < s.Length; right++) {
        while (window.Contains(s[right])) {
            window.Remove(s[left]);
            left++;
        }
        window.Add(s[right]);
        maxLen = Math.Max(maxLen, right - left + 1);
    }
    return maxLen;
}



int MaxSumK(int[] arr, int k) {
    int sum = arr.Take(k).Sum();
    int maxSum = sum;

    for(int i = k; i< arr.Length; i++){
        sum = sum + arr[i] - arr[i-k];
        if(sum > maxSum)
            maxSum = sum;
    }
    return maxSum;
}



// Max sum of 3 consecutive: 9
// Longest unique substring of "abcabcbb": 3
// Longest unique substring of "bbbbb": 1
// Longest unique substring of "pwwkew": 3
// Smallest subarray with sum ≥ 7: 2
// Smallest subarray with sum ≥ 100: 0
// Longest with at most 2 distinct in "eceba": 3