using System;

class CalculateTheExpression
{
    static void Main()
    {
        //CalculateTheExpression Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double factN = 1;
        double powern = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            powern *= x;
            sum += (factN / powern);
        }
        Console.WriteLine("{0:0.00000}", sum);        

    }
}

