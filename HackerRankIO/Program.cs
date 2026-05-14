using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(string[] args) {
        string line1 = "42";
        int num = int.Parse(line1);
        Console.WriteLine($"Got: {num}");

        string line2 = "5 12 3 18 7";
        int[] arr = line2.Split(" ").Select(x => int.Parse(x)).ToArray();
        Console.WriteLine($"Array: {string.Join(" ", arr)}");

        string line3 = "5 3";
        int[] nums = line3.Split(" ").Select(x => int.Parse(x)).ToArray();
        int n = nums[0], m= nums[1];
        Console.WriteLine($"n={n}, m={m}");

        string[] lines4 = new[] { "5", "10 20 30 40 50" };
        int n4 = int.Parse(lines4[0]);
        int[] arr4 = lines4[1].Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine($"N={n4}, sum={arr4.Sum()}");

        string[] lines5 = new[] { "3", "alice", "bob", "charlie" };
        int n5 = int.Parse(lines5[0]);
        string[] names = new string[n5];
        for (int i = 0; i < n5; i++) {
            names[i] = lines5[1 + i];
        }
        Console.WriteLine($"Names: {string.Join(", ", names)}");
    }
}
