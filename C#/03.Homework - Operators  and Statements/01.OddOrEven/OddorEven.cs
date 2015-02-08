using System;

class OddorEven
{
    static void Main()
    {

        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(isOdd(num));



    }
     public static bool isOdd(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
}

