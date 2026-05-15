using System.Text;
class Solution
{
    static bool IsSubsequence(string word, string s) {
        int i = 0, j = 0;
        while (i < word.Length && j < s.Length) {
            if (word[i] == s[j]) i++;
            j++;
        }
        return i == word.Length;
    }
    static string LongestWord(string s, List<string> dict) {
        string best = "";
        foreach (string word in dict) {
            if (IsSubsequence(word, s)) {
                if (word.Length > best.Length || 
                (word.Length == best.Length && string.CompareOrdinal(word, best) < 0)) {
                    best = word;
                }
            }
        }
        return best;
    }

    static void Main(string[] args){
        string s = "abpcplea";
        List<string> dictionary = new() { "ale", "apple", "monkey", "plea" };
        string result = LongestWord(s, dictionary);
        Console.WriteLine($"Test 1: {result}");

        s = "abpcplea";
        dictionary = new() {"a", "b", "c"};
        result = LongestWord(s, dictionary);
        Console.WriteLine($"Test 2: {result}");

        s = "abce";
        dictionary = new() {"abe", "abc", "xyz"};
        result = LongestWord(s, dictionary);
        Console.WriteLine($"Test 3: {result}");

        s = "";
        dictionary = new() {"xyz", "qrs"};
        result = LongestWord(s, dictionary);
        Console.WriteLine($"Test 4: {result}");
    }
}
