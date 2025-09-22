using System;

class Program
{
    static void Main()
    {
        Console.Write("principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("rate: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("time: ");
        double time = double.Parse(Console.ReadLine());
        double interest = (principal * rate * time) / 100;
        Console.WriteLine($"interest: {interest}");
    }
}
