using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n;
        int height = (2 * width) - 1;
        int asterixes = 1;
        int dotsr = n - 1;
        int dotsl = 0;
        while (true)
        {
            DrawLine(dotsl, asterixes, dotsr);
            dotsl++;
            dotsr--;
            Console.WriteLine();
            if (dotsr == -1)
            {
                break;
            }
        }
        asterixes = 1;
        dotsr = 1;
        dotsl = n - 2;
        while (true)
        {
            DrawLine(dotsl, asterixes, dotsr);
            dotsl--;
            dotsr++;
            Console.WriteLine();
            if (dotsl == -1)
            {
                break;
            }
        }
    }

    private static void DrawLine(int dotsl, int asterixes, int dotsr)
    {
        for (int i = 0; i < dotsl; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < asterixes; i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < dotsr; i++)
        {
            Console.Write('.');
        }
    }
}

