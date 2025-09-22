using System;

class Program
{
    static void Main()
    {
        Console.Write("weight (kg): ");
        if (!double.TryParse(Console.ReadLine(), out double weight))
        {
            Console.WriteLine("invalid weight");
            return;
        }
        Console.Write("height (m): ");
        if (!double.TryParse(Console.ReadLine(), out double height))
        {
            Console.WriteLine("invalid height");
            return;
        }
        double bmi = weight / (height * height);
        Console.WriteLine($"bmi: {bmi}");
    }
}
