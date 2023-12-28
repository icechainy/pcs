using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // initializing l and sequence
        int L = 5;
        string[] sequence = { "12345", "67890", "abcde", "fghij", "klmno", "pqrst", "uvwxy", "z1234" };

        // last digit string with l length
        string lastStringStartingWithDigit = sequence.LastOrDefault(s => char.IsDigit(s[0]) && s.Length == L);

        // results
        if (lastStringStartingWithDigit != null)
        {
            Console.WriteLine("Последняя строка, начинающаяся с цифры и имеющая длину " + L + ": " + lastStringStartingWithDigit);
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}