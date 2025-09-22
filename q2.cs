using System;

class Program
{
    static void Main()
    {
        string input = "123abc";
        if (int.TryParse(input, out int result))
        {
            Console.WriteLine($"Converted value: {result}");
        }
        else
        {
            Console.WriteLine("The string contains non numeric");
        }
    }
}
