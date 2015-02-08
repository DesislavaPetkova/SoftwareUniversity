using System;

class JoroTheFootballPLayer
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double result = 0;
        int weeks = 52;
        
        result = weeks - h;
        result = result * 0.66d;
        result = result + h * 1d + p / 2d;
        if (year == "t")
        {
            result = result + 3;
        }
        Console.WriteLine("{0:0}", result);

    }
}

