using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Type two variables");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        if (a > b)
        {           
            float c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}

