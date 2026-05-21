class Solution{
    static int[] indicesOfSum(int[] arr, int target){
        Dictionary<int, int> numberWithIndices = new();
        for(int i = 0; i< arr.Length; i++){
            int rem = target - arr[i];
            if(numberWithIndices.GetValueOrDefault(rem, -1) == -1){
                numberWithIndices[arr[i]] = i; 
            }
            else{
                return new int[]{numberWithIndices[rem], i};
            }
        }
        return new int[2];
    }
    public static void Main(String[] args){
        int[] arr = new int[] {2, 7, 11, 15};
        int target = 9;
        Console.WriteLine($"{string.Join(" ", indicesOfSum(arr, target))}");
        
    }
}