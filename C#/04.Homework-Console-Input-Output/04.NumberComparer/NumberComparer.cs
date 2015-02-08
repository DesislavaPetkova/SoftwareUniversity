using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter 2 integers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(a, b));
        
    }
}

