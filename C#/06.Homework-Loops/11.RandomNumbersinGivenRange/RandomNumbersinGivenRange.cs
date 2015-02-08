using System;

class RandomNumbersinGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 1; i <= n; i++)
        {
            int random = rnd.Next(min, max + 1);            
            Console.Write("{0} ", random);
        }        
    }
}

