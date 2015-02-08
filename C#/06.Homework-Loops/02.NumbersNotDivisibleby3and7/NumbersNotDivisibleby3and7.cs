using System;

class NumbersNotDivisibleby3and7
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 1; i <= count; i++)
        {
            if (((i % 3) != 0) && ((i % 7) != 0))
            {
                Console.Write("{0} ", i);
            }
        }                        
    }
}
