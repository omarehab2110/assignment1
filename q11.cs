using System;

class Program
{
    static void Main()
    {
        Console.Write("day: ");
        if (!int.TryParse(Console.ReadLine(), out int day))
        {
            Console.WriteLine("invalid day");
            return;
        }
        Console.Write("month: ");
        if (!int.TryParse(Console.ReadLine(), out int month))
        {
            Console.WriteLine("invalid month");
            return;
        }
        Console.Write("year: ");
        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("invalid year");
            return;
        }
        Console.WriteLine($"date: {day},{month},{year}");
        Console.WriteLine($"date: {day}/{month}/{year}");
        Console.WriteLine($"date: {day}-{month}-{year}");
    }
}
