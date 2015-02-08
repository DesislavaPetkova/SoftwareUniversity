using System;

class ModifyaBitatGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Type an integer n and a value (v) to change a given bit at index p");
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result = n | mask;
        if (v == 0)
        {
            mask = ~(1 << p);
            result = n & mask;
        }
        Console.WriteLine(result);
        Console.WriteLine("Binary result");
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.WriteLine("Decimal result");
        Console.WriteLine(result);
    }
}

