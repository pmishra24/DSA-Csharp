class Solution{

    public static int find(int x, int[] parent){
        if(parent[x] != x){
            parent[x] = find(parent[x], parent);
        }
        return parent[x];
    }

    public static int union(int x, int y, int[] parent, int count){
        int rootX = find(x, parent);
        int rootY = find(y, parent);

        if(rootX != rootY){
            parent[rootY] = rootX;
            count--;
        }
        return count;
    }

   public static int CountComponents(int n, int[][] edges) {
        int[] parent = new int[n];
        int count = n;
        for(int i=0; i< n; i++) parent[i] = i;
        foreach(var edge in edges){
            count = union(edge[0], edge[1], parent, count);
        }
        Console.WriteLine($"{string.Join(" " , parent)}");
        return count; 
    }

    public static void Main(string[] args) {
        Console.WriteLine(CountComponents(5, new int[][] {
            new int[] { 0, 1 },
            new int[] { 1, 2 },
            new int[] { 3, 4 }
        }));  // expects 2
        
        Console.WriteLine(CountComponents(5, new int[][] {
            new int[] { 0, 1 },
            new int[] { 1, 2 },
            new int[] { 2, 3 },
            new int[] { 3, 4 }
        }));  // expects 1
        
        Console.WriteLine(CountComponents(4, new int[][] { }));  // expects 4
    }
}