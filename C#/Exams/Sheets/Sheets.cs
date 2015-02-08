using System;


public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int digit = 0;
        int count = 10;

        for (int i = 0; i <= 10; i++)
        {
            digit = n & (1 << i);
            if (digit == 0)
            {
                Console.WriteLine("A{0}", count - i);
            }
        }
    }
}
