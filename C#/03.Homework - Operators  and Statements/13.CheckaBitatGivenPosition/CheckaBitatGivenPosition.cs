using System;

class CheckaBitatGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Type an integer n and a value of given bit at index p");
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int result = nRightP & 1;
        bool resultb = result == 1;
        if (resultb == true)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }             
    }
}

