using System.Text;
class Solution
{
    static string BuildString(int n) {
        StringBuilder sb = new();
        for (int i = 0; i < n; i++) {
            if (sb.Length >= 2 && sb[sb.Length - 1] == 'b' && sb[sb.Length - 2] == 'b')
                sb.Append('a');
            else
                sb.Append('b');
        }
        return sb.ToString();
    }

    static void Main(string[] args){
        int n = 1;     // try 1, 2, 5, 7, 10
        string result = BuildString(n);
        Console.WriteLine($"n={n}: {result}");
        n = 2;     // try 1, 2, 5, 7, 10
        result = BuildString(n);
        Console.WriteLine($"n={n}: {result}");
        n = 5;     // try 1, 2, 5, 7, 10
        result = BuildString(n);
        Console.WriteLine($"n={n}: {result}");
        n = 7;     // try 1, 2, 5, 7, 10
        result = BuildString(n);
        Console.WriteLine($"n={n}: {result}");
        n = 10;     // try 1, 2, 5, 7, 10
        result = BuildString(n);
        Console.WriteLine($"n={n}: {result}");
    }
}