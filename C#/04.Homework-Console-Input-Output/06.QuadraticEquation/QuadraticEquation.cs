using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter value for \"a\"");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for \"b\"");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for \"c\"");
        float c = float.Parse(Console.ReadLine());
        float d = (b * b) - 4 * (a) * (c);
        //Console.WriteLine(d);
        //if (b % 2 == 0)
        //{
            //float k = b / 2;
          //  float d2 = (b * b) - (a) * (c);
        //}
        float result;                
        float result1;
        float result2;
        if (d > 0)
        {
            result2 = (-b + (float)Math.Sqrt(d)) / (2 * a);
            result1 = (-b - (float)Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1={0}, x2={1}", result1, result2);
        }
        else if (d < 0) 
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            result = -b / 2 * a;
            Console.WriteLine(result);
        }
    }
}

