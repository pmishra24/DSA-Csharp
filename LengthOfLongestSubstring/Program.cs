class Solution{
    public static int LengthOfLongestSubstring(string s) {
    if (string.IsNullOrEmpty(s)) return 0;
    
    var seen = new HashSet<char>();
    int left = 0, maxLength = 0;
    
    for (int right = 0; right < s.Length; right++) {
        // Shrink window until s[right] can be added uniquely
        while (seen.Contains(s[right])) {
            seen.Remove(s[left]);
            left++;
        }
        
        seen.Add(s[right]);
        maxLength = Math.Max(maxLength, seen.Count);
    }
    
    return maxLength;
}
   

    public static void Main(string[] args) {
        string word = "abca";
        Console.WriteLine(LengthOfLongestSubstring(word));
    }
}