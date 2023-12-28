using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // d, k, sequence
        int D = 5;
        int K = 3;
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // first fragment
        var firstFragment = sequence.TakeWhile(n => n <= D);

        // second fragment
        var secondFragment = sequence.Skip(K - 1);

        // combine and delete
        var union = firstFragment.Concat(secondFragment).Distinct();

        // sorting
        var sortedUnion = union.OrderByDescending(n => n);

        // result
        Console.WriteLine("Отсортированная последовательность: " + string.Join(", ", sortedUnion));
    }
}