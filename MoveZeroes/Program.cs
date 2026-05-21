class Solution{
    static int[] moveZeroes(int[] arr){
        for(int i =0, j= 0; j< arr.Length; j++){
            if(arr[j] != 0){
                (arr[i], arr[j]) = (arr[j], arr[i]);
                i++;
            }
        }
       
        return arr;
    }
    public static void Main(String[] args){
        int[] arr = new int[] {1,0, 0 ,3,12};
        Console.WriteLine($"{string.Join(" ", moveZeroes(arr))}");
        
    }
}