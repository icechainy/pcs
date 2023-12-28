using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // number order
        int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

        // first positive element
        int firstPositive = sequence.FirstOrDefault(n => n > 0);

        // last negative element
        int lastNegative = sequence.LastOrDefault(n => n < 0);

        // results
        Console.WriteLine("Первый положительный элемент: " + firstPositive);
        Console.WriteLine("Последний отрицательный элемент: " + lastNegative);
    }
}