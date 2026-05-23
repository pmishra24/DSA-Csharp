class Solution{

    public static int MinKnightMoves(int n, int startR, int startC, int targetR, int targetC) {
        if(startR == targetR && startC == targetC) return 0;
        int[][] moves = new []{
            new int[] {2, -1},
            new int[]{2, 1},
            new int[]{-2, -1},
            new int[]{-2, 1},
            new int[]{1, -2},
            new int[]{-1, -2},
            new int[]{1, 2},
            new int[]{-1, 2}
        };
        int count = 0;

        Queue<(int, int)> toVisit = new();
        HashSet<(int, int)> visited = new();
        toVisit.Enqueue((startR, startC));
        visited.Add((startR, startC));

        while(toVisit.Count > 0){
            
            int level = toVisit.Count;
            count++;
            for(int i =0; i< level; i++){
                var (r, c) = toVisit.Dequeue();
                foreach(var move in moves){
                    int newMoveR = r + move[0];
                    int newMoveC = c + move[1];
                    if(newMoveR == targetR && newMoveC == targetC) return count;

                    if(newMoveR >= 0 && newMoveC >= 0 && newMoveR < n && newMoveC < n && visited.Add((newMoveR, newMoveC))){
                        toVisit.Enqueue((newMoveR, newMoveC));
                    }
                }
            }
            
        }

        return -1;

    }
   

    public static void Main(string[] args) {
        Console.WriteLine(MinKnightMoves(8, 0, 0, 2, 1));   // expects 1
        Console.WriteLine(MinKnightMoves(8, 0, 0, 5, 5));   // expects 4
        Console.WriteLine(MinKnightMoves(8, 0, 0, 0, 0));   // expects 0
        Console.WriteLine(MinKnightMoves(8, 0, 0, 7, 7));   // expects 6
    }
}