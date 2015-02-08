using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Type your number n");
        int n = int.Parse(Console.ReadLine());
        int i = 0;
        int a = 0;
        int b = 1;
        int sum = 1;        
        while (i < (n-1))
        {
            if ((a + b) == 1)
            {
                Console.Write("{0}, ", a, b); 
            }
            Console.Write("{0}, ", sum);
            sum = a + b;
            a = b;
            b = sum;
            i++;

        }        
    }
}

