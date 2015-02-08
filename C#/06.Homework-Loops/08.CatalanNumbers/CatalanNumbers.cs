using System;

class CatalanNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double facN = 1;
        double fac2N = 1;
        double facN1 = 1;
        for (int i = 1; i <= (1 + n); i++)
        {
            facN1 *= i;
            if (i <= n)
            {
                facN *= i;
            }
        }
        for (int i = 1; i <= (2 * n); i++)
        {
            fac2N *= i;
        }
        double result = (fac2N / (facN1 * facN));
        Console.WriteLine("{0}", result);
        //Console.WriteLine("{0} {1} {2}", facN, fac2N, facN1);
    }
}

