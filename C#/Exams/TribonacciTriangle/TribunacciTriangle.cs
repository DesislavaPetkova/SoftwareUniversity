using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long l = long.Parse(Console.ReadLine());        
        long raboten = 0;
        Console.WriteLine(a);
        Console.WriteLine(b + " " + c);

        if (l <= 2)
        {
            return;
        }

        for (long i = 2; i < l; i++)
        {
            for (long j = 0; j <= i; j++)
            {
                raboten = a + b + c;

                if (j == i)
                {
                    Console.Write(raboten);
                    a = b;
                    b = c;
                    c = raboten;
                    break;
                }

                Console.Write(raboten + " ");
                a = b;
                b = c;
                c = raboten;
            }
            Console.WriteLine();
        }
    }
}

