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

    public static List<List<int>> LevelOrder(TreeNode? root) {
        List<List<int>> levelOrder = new ();
        if(root == null) return levelOrder;
        
        Queue<TreeNode> levelOrderQueue = new();
        levelOrderQueue.Enqueue(root);

        while(levelOrderQueue.Count > 0){
            int levelSize = levelOrderQueue.Count;
            List<int> levelNodes = new();
            for(int i =0; i< levelSize; i++){
                var node = levelOrderQueue.Dequeue();
                levelNodes.Add(node.val);
                if(node.left != null) levelOrderQueue.Enqueue(node.left);
                if(node.right != null) levelOrderQueue.Enqueue(node.right);
            }
            levelOrder.Add(levelNodes);
        }

        return levelOrder;
    }
   

    public static void Main(string[] args) {
        var root = new TreeNode(3, 
            new TreeNode(9), 
            new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        
        var result = LevelOrder(root);
        foreach (var level in result) {
            Console.WriteLine($"[{string.Join(", ", level)}]");
        }
        // expects:
        // [3]
        // [9, 20]
        // [15, 7]
        
        Console.WriteLine("---");
        
        var empty = LevelOrder(null);
        Console.WriteLine(empty.Count == 0 ? "empty" : "non-empty");  // expects empty
    }
}