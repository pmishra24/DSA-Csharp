class Solution{
    public static int minimumSizeSubarraySum(int[] arr, int target) {
    int sum = 0;
    int minLength = arr.Length + 1;
    
    for(int i =0, j=0; j < arr.Length; j++){
        sum += arr[j];
        if(sum >= target)
        {
            while(sum >= target){
                minLength = Math.Min(minLength, j-i+1);
                sum -= arr[i];
                i++;      
            }
        }
        
        
    }
    
    return minLength <= arr.Length ? minLength : 0;
}
   

    public static void Main(string[] args) {
        int[] arr = new [] {2, 3, 1, 2, 4, 3};
        int target = 7;
        Console.WriteLine(minimumSizeSubarraySum(arr, target));
    }
}