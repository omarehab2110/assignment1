using System;

public class ReadNumber
{
    public static void Main(string[] args)
    {
        Console.Write("number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"entered: {number}");
    }
}
