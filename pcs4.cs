using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // initializing d and sequence
        int D = 5;
        int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10, 25, 35, 45, -55 };

        // extract numbers
        var extractedNumbers = sequence.SkipWhile(n => n <= D).Where(n => n > 0 && n % 2 != 0).Reverse();

        // result
        Console.WriteLine("Извлеченные числа: " + string.Join(", ", extractedNumbers));
    }
}