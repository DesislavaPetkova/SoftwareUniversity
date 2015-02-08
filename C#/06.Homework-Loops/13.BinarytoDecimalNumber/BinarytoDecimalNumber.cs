using System;
using System.Linq;
class BinarytoDecimalNumber
{
    static void Main()
    {
        string bin = Console.ReadLine();
        long dec = 0;
        for (int i = 0; i < bin.Length; i++)
        {
            dec += (long)Math.Pow(2, i);            
        }
        Console.WriteLine(dec);
    }
}

