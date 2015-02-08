using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        double X = double.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());
        int result = 0;
        if (X == 0 && Y == 0)
        {
            result = 0;
            Console.WriteLine(result);
        }
        else if (X > 0 && Y > 0)
        {
            result = 1;
            Console.WriteLine(result);
        }
        else if (X < 0 && Y > 0)
        {
            result = 2;
            Console.WriteLine(result);
        }
        else if (X < 0 && Y < 0)
        {
            result = 3;
            Console.WriteLine(result);
        }
        else if (X > 0 && Y < 0)
        {
            result = 4;
            Console.WriteLine(result);
        }
        else if (X == 0)
        {
            result = 5;
            Console.WriteLine(result);
        }
        else if (Y == 0)
        {
            result = 6;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("invalide location");
        }
    }
}

