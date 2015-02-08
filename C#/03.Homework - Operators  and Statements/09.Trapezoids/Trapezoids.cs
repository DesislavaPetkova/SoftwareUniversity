using System;

class Trapezoids
{
    static void Main()
    {
        // S = 0.5*(a + b)*h
        Console.WriteLine("Please enter your side a, b and h to calculate the area of give Trapezoid: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine(0.5 * (a + b) * h);
    }
}

