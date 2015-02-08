using System;
class CalculateNandK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int facN = 1;
        int facK = 1;
        for (int i = 1; i <= n; i++)
        {
            facN *= i;
            if (i <= k)
            {
                facK *= i;
            }
        }
        Console.WriteLine(facN / facK);
    }
}

