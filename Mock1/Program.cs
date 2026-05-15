

class Solution {
    static int MinimumSwaps(string s1, string s2){
        int minSwap = 0;
        int type1 = 0;
        int type2 = 0;
        if(((s1.Count(z=> z=='y')) + (s2.Count(z=> z=='y'))) % 2 != 0)
            return -1;
        for(int i = 0; i< s1.Length; i++){
            if(s1[i] == 'x' && s2[i] == 'y'){
                type1++;
            }
            if(s1[i] == 'y' && s2[i] == 'x')
                type2++;
        }
        minSwap = type1/2;
        minSwap += type2/2;
        if(type1 % 2 ==0 && type2 % 2 == 0)
            return minSwap;
        return minSwap + 2;
    }
    static void Main(string[] args) {
       string s1 = "xx";
       string s2 = "yy";

        Console.WriteLine($"Minimum swaps for {s1} and {s2}: {MinimumSwaps(s1, s2)}");
        Console.WriteLine($"Minimum swaps for {"xxyyxyxyxx"} and {"xyyxyxxxyx"}: {MinimumSwaps("xxyyxyxyxx", "xyyxyxxxyx")}");
        Console.WriteLine($"Minimum swaps for {"xy"} and {"yx"}: {MinimumSwaps("xy", "yx")}");
        Console.WriteLine($"Minimum swaps for {"xx"} and {"xy"}: {MinimumSwaps("xx", "xy")}");

       
    }
}
