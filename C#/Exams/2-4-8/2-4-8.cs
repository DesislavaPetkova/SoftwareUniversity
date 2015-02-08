using System;

class Program
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal rezult = 0;
        if (b == 2)
        {
            rezult = a % c;
        }
        else if (b == 4)
        {
            rezult = a + c;
        }
        else if (b == 8)
        {
            rezult = a * c;
        }
        if (rezult % 4 == 0)
        {
            Console.WriteLine(rezult / 4);
        }
        else if (rezult % 4 != 0)
        {
            Console.WriteLine(rezult % 4);
        }
        Console.WriteLine(rezult);
    }
}

