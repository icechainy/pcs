using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // k and sequence
        int K = 5;
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // first fragment
        var firstFragment = sequence.Where(n => n % 2 == 0);

        // second fragment
        var secondFragment = sequence.Skip(K);

        // diff and delete
        var difference = firstFragment.Except(secondFragment).Distinct();

        // reversing
        var reversedDifference = difference.Reverse();

        // result
        Console.WriteLine("Разность последовательностей: " + string.Join(", ", reversedDifference));
    }
}