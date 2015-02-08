using System;

class Numbersfrom1toN
{
    static void Main()
    {
        Console.WriteLine("Enter a number NAO!");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}

