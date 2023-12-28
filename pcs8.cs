using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // k and sequence
        int K = 2;
        string[] sequence = { "ABC", "DEF", "123", "GHI", "JKL", "MNO", "PQR", "STU", "VWX", "YZ0" };

        // first fragment
        var firstFragment = sequence.Take(3 * K);

        // second fragment
        var secondFragment = sequence.SkipWhile(s => !char.IsDigit(s[s.Length - 1]));

        // intersection and delete
        var intersection = firstFragment.Intersect(secondFragment).Distinct();

        // sorting
        var sortedIntersection = intersection.OrderBy(s => s.Length).ThenBy(s => s);

        // result
        Console.WriteLine("Отсортированная последовательность: " + string.Join(", ", sortedIntersection));
    }
}