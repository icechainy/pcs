using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // initiliazing k and string sequence
        int K = 5;
        string[] sequence = { "Hello", "World", "Csharp", "is", "Awesome", "!", "12345" };

        // extract from a
        var extractedStrings = sequence.Take(K).Where(s => s.Length % 2 != 0 && char.IsUpper(s[0])).Reverse();

        // result
        Console.WriteLine("Извлеченные строки: " + string.Join(", ", extractedStrings));
    }
}