using System;

class DecimaltoBinaryNumber
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        long raboten = dec;
        string binary = "";
        while (raboten > 0)
        {
            long reminder = raboten % 2;
            raboten = raboten / 2;
            binary = reminder.ToString() + binary;
        }
        Console.Write(binary);
    }
}

