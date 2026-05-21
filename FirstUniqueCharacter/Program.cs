class Solution{
    static int FirstUniqueCharacterIndex(string word){
        int[] charCount = new int[26];

        for(int i =0; i< word.Length; i++){
            charCount[word[i] - 'a']++;
        }
        for(int i =0; i< word.Length; i++){
            if(charCount[word[i] - 'a'] == 1)
                return i;
        }
        return -1;
    }
    public static void Main(String[] args){
        string word = "prasharp";
        Console.WriteLine($"{FirstUniqueCharacterIndex(word)}");
        
    }
}