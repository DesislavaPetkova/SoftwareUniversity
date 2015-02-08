using System;
using System.Globalization;

class MathExpression
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double result = (((Math.Pow(n, 2)) + (1 / (m * p)) + 1337) / (n - (128.523123123 * p))) + Math.Sin(((int)m % 180));
        Console.WriteLine(result.ToString("0.000000", CultureInfo.CurrentCulture));
    }
}

