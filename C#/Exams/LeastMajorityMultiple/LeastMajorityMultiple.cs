using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int raboten = 1;
        int counter = 0;
        while (true)
        {
            if (raboten % a == 0)
            {
                counter++;
            }
            if (raboten % b == 0)
            {
                counter++;
            }
            if (raboten % c == 0)
            {
                counter++;
            }
            if (raboten % d == 0)
            {
                counter++;
            }
            if (raboten % e == 0)
            {
                counter++;
            }
            if (counter >= 3)
            {
                Console.WriteLine(raboten);
                break;
            }
            raboten++;
            counter = 0;

        }

    }
}

