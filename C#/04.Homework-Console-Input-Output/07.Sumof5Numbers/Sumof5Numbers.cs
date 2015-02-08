using System;

class Sumof5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} {1} {2} {3} {4} " + (a + b + c + d + e), a, b, c, d, e);
    }
}

