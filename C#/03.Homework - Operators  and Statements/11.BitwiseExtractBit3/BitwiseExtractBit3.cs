using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter the number and we will check the value of the position No.3: ");
        int number = int.Parse(Console.ReadLine());
        int p = 3;
        int nRightP = number >> 3;
        int bit = nRightP & 1;
        Console.WriteLine("The value of the number on position No.3 is: {0}", bit);
        
    }
}

