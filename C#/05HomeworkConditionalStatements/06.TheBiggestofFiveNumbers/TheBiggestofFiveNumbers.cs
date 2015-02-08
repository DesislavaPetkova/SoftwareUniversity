using System;

class TheBiggestofFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers: ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float d = float.Parse(Console.ReadLine());
        float e = float.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine(c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }
    }
}

