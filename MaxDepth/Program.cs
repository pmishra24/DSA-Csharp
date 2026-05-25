class Solution{

   public class TreeNode {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static int MaxDepth(TreeNode? root) {
        if(root == null) return 0;
        return Math.Max(MaxDepth(root.left) + 1, MaxDepth(root.right) + 1);
    }
   

    public static void Main(string[] args) {
        // Tree:    3
        //         / \
        //        9   20
        //            / \
        //           15  7
        var root = new TreeNode(3, 
            new TreeNode(9), 
            new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        Console.WriteLine(MaxDepth(root));  // expects 3
        
        Console.WriteLine(MaxDepth(null));   // expects 0
        
        var single = new TreeNode(1);
        Console.WriteLine(MaxDepth(single)); // expects 1
    }
}