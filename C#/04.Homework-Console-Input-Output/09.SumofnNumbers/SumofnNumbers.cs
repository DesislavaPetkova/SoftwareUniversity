using System;

class SumofnNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i=0; i<n; i++)
        {
            Console.Write("X = ");
            sum = sum + int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}

