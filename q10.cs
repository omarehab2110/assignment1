using System;

class Program
{
    static void Main()
    {
        Console.Write("temperature: ");
        if (int.TryParse(Console.ReadLine(), out int temp))
        {
            string result = temp < 10 ? "cold" : temp > 30 ? "hot" : "good";
            Console.WriteLine($"status: {result}");
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}
