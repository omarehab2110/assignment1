using System;

class Program
{
    static void Main()
    {
        string text = "Hello, World!";
        string sub = text.Substring(7, 5);
        Console.WriteLine($"Extracted substring: {sub}");
    }
}
