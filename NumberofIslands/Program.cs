class Solution{

    public static int NumIslands(char[][] grid) {
        int rows = grid.Length;
        if (grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;
        int cols = grid[0].Length;
        int[][] dirs = new []{
            new int[]{-1, 0},
            new int[]{1, 0},
            new int[]{0, -1},
            new int[]{0, 1}
        };

        Queue<(int, int)> islands = new();
        int count = 0;

        for(int r =0; r< rows; r++){
            for(int c=0; c< cols; c++){
                if(grid[r][c] == '1'){
                    count++;
                    islands.Enqueue((r, c));
                    grid[r][c] = '0'; 
                    while(islands.Count > 0){
                        var (vr, vc) = islands.Dequeue();
                        foreach(var dir in dirs){
                            int newR = vr + dir[0];
                            int newC = vc + dir[1];
                            if(newR >= 0 && newR < rows && newC >=0 && newC < cols && grid[newR][newC] == '1'){
                                islands.Enqueue((newR, newC));
                                grid[newR][newC] = '0';
                            }
                        }
                    }
                }
            }
        }
        return count;
    }
   

    public static void Main(string[] args) {
        char[][] grid1 = new char[][] {
            new char[] { '1','1','1','1','0' },
            new char[] { '1','1','0','1','0' },
            new char[] { '1','1','0','0','0' },
            new char[] { '0','0','0','0','0' }
        };
        Console.WriteLine(NumIslands(grid1));  // expects 1
        
        char[][] grid2 = new char[][] {
            new char[] { '1','1','0','0','0' },
            new char[] { '1','1','0','0','0' },
            new char[] { '0','0','1','0','0' },
            new char[] { '0','0','0','1','1' }
        };
        Console.WriteLine(NumIslands(grid2));  // expects 3
    }
}