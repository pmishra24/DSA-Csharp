class Solution{

    public static IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 2; i++) {
            // Skip duplicate values for i
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            int left = i + 1;
            int right = nums.Length - 1;
            
            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                
                if (sum == 0) {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                    // Skip duplicates for left and right
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    
                    left++;
                    right--;
                }
                else if (sum < 0) {
                    left++;  // need a bigger sum
                }
                else {
                    right--; // need a smaller sum
                }
            }
        }
        
        return result;
    }
   

    public static void Main(string[] args) {
        var result = ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
        foreach (var triplet in result) {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }
}