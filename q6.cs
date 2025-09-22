using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = str1;
        str2 = "World";
        Console.WriteLine($"str1: {str1}, str2: {str2}");
        // Changing str2 does not affect str1 because strings are immutable and assignment creates a new reference.
    }
}
