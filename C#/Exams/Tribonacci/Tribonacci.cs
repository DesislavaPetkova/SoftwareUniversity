using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger raboten = 0;        
        for (int i = 1; i < n - 2; i++)
        {
            raboten = a + b + c;
            a = b;
            b = c;
            c = (BigInteger)raboten;
        }
        switch (n)
        {
            case 1:
                {
                    Console.WriteLine(a);
                    break;
                }
            case 2:
                {
                    Console.WriteLine(b);
                    break;
                }
            case 3:
                {
                    Console.WriteLine(c);
                    break;
                }
        }
        if (n > 3)
        {
            Console.WriteLine(raboten); 
        }
    }
}

