using System;

class ThirdDigitis7
{
    static void Main()
    {
        Console.WriteLine("Inser number : ");
        int number = int.Parse(Console.ReadLine());
        number = (number/100)%10;
        if (number == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

    }
}
