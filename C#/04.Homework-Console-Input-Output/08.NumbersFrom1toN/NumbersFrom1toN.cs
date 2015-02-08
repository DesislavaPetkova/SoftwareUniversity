using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.WriteLine("Type a number");        
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= n)
        {
            Console.WriteLine("{0, 8}", counter);
            counter++;
        }
    }
}
