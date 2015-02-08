using System;

class CirclePerimeterandArea
{
    static void Main()
    {
        Console.WriteLine("Type the radius of ur circle");
        double r = double.Parse(Console.ReadLine());
        double perimeterr = 2 * Math.PI * r;
        double area = Math.PI * (r * r);
        Console.WriteLine("The perimeter is {0:0.00}, and the area is {1:0.00}", perimeterr, area);
    }
}

