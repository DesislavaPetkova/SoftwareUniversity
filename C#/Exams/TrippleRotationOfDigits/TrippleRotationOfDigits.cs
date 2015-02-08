using System;

class TrippleRotationOfDigits
{
    static void Main()
    {
        long k = long.Parse(Console.ReadLine());
        string reverse;
        for (int i = 0; i < 3; i++)
        {
            long diggit = k % 10;
            if (diggit == 0)
            {
                k = k / 10;
                continue;
            }
            if (k < 0)
            {
                break;
            }
            k = k / 10;
            string newnum = k.ToString();
            reverse = diggit + newnum;
            k = long.Parse(reverse);                       
        }
        Console.WriteLine(k);
    }
}

