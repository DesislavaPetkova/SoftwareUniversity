using System;

class PointinaCircle
{
    static void Main()
    {
        Console.WriteLine("x = " );
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("y = " );
        double y = double.Parse(Console.ReadLine());
        double radius = 2;
        bool inside = (x * x) + (y * y) <= (radius * radius);
        Console.WriteLine("The cordinates of your point are inside the circle = {0}", inside);
    }
}

