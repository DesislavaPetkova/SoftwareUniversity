using System;

class CalculateNnK_N_K
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());
        double dif = n - k;
        double facdif = 1;
        for (double j = 1; j <= dif; j++)
        {
            facdif *= j;
        }
        double facN = 1;
        double facK = 1;
        for (double i = 1; i <= n; i++)
        {
            facN *= i;
            if (i <= k)
            {
                facK *= i;
            }
        }
        Console.WriteLine("{0} {1} {2}", facN, facK, facdif );
        Console.WriteLine(facN / (facK * facdif));
    }
}

