using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string a = Console.ReadLine();
        string[] splitted = a.Split(' ');
        int odd = 0;
        for (int i = 0; i < splitted.Length; i++)
        {
            int raboten = int.Parse(splitted[i]);
            bool isodd = ((i % 2) != 0);
            if (isodd)
            {
                odd += raboten;
                Console.WriteLine(odd);
            }
        }

    }
}

