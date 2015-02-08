using System;

class ExtractBitfromInteger
{
    static void Main()
    {
        Console.WriteLine("Type an integer n and a value of given bit at index p");
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int result = nRightP & 1;
        Console.WriteLine("The value of index p of your integer N is : {0}", result);        
    }
}

