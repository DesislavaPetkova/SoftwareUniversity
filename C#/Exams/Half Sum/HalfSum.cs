using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = 0;
        int sum = 0;
        int diff = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int t = 0; t < n; t++)
            {
                sum += int.Parse(Console.ReadLine());

            }
            if (m == 0)
            {
                m = sum;
            }
            else if (sum > m)
            {
                diff = sum - m;
            }
            else if (m > sum)
            {
                diff = m - sum;
            }

            sum = 0;
        }
        if (diff > 0)
        {
            Console.WriteLine("No, diff={0}", diff);
        }
        else
        {
            Console.WriteLine("Yes, sum={0}", m);
        }
    }
}

