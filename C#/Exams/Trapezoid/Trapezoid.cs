using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int widtht = n;
        int widthb = 2 * n;
        int height = n + 1;
        int asterix = 1;
        int asterixes = 1;
        int dotsl = n - 1;
        int dotsr = n - 1;        
        Console.WriteLine(new String ('.', n) + new String ('*', n));
        while (true)
        {
            DrawLine(dotsl, asterix, dotsr, asterix);
            dotsl--;
            dotsr++;
            Console.WriteLine();
            if (dotsl == 0)
            {
                break;
            }
        }
        Console.WriteLine(new String ('*', (2 * n)));
    }

    private static void DrawLine(int dotsl, int asterix, int dotsr, int asterixes)
    {
        for (int i = 0; i < dotsl; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < asterix; i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < dotsr; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < asterixes; i++)
        {
            Console.Write('*');
        }
    }
}

