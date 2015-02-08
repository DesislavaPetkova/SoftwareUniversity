using System;

class MatrixofNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 20)
        {
            
            for (int a = 1; a <= n; a++)
            {
                for (int b = a; b < n + a; b++)
                {
                    Console.Write("{0} ", b);
                }
                
                Console.WriteLine();
            }

        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}

