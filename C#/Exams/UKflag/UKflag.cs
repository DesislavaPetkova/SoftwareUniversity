using System;

class UKflag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dash = (n / 2) - 1;       
        int slash = 1;
        int backsclash = 1;
        int dotsn = ((n - 3) / 2);
        int dotsm = ((n - 3) / 2);
        int dotsr = 0;
        int dotsl = 0; 
        int vertical = 1;
        //Console.WriteLine(new String('\\', 1) + new String('.', (n - 3) / 2) + new String('|', 1) + new String('.', (n - 3) / 2) + new String('/', 1));
        for (int i = 0; i < ((n - 1) / 2); i++)
        {
            DrawLine(dotsl, backsclash, dotsn, vertical, dotsm, slash, dotsr);
            dotsl++;
            dotsr++;
            dotsn--;
            dotsm--;
            if (dotsm == 0)
            {
                break;
            }
        }
        Console.WriteLine(new String('.', (n - 3)/ 2) + new String('\\', 1) + new String('|', 1) + new String('/', 1) + new String('.', (n - 3)/ 2));
        Console.WriteLine(new String('-', (n - 1) / 2)+ new String('*', 1)+ new String('-', (n - 1) / 2));
        Console.WriteLine(new String('.', (n - 3) / 2) + new String('/', 1) + new String('|', 1) + new String('\\', 1) + new String('.', (n - 3) / 2));
        for (int i = 0; i < ((n - 1) / 2); i++)
        {
            dotsl--;
            dotsr--;
            dotsn++;
            dotsm++;
            DrawLineN(dotsl, backsclash, dotsn, vertical, dotsm, slash, dotsr);
            if (dotsr == 0)
            {
                break;
            }
        }
        //Console.WriteLine(new String('/', 1) + new String('.', (n - 3) / 2) + new String('|', 1) + new String('.', (n - 3) / 2) + new String('\\', 1));
    }

    private static void DrawLineN(int dotsl, int backsclash, int dotsn, int vertical, int dotsm, int slash, int dotsr)
    {
        for (int i = 0; i < dotsl; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < backsclash; i++)
        {
            Console.Write('/');
        }
        for (int i = 0; i < dotsn; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < vertical; i++)
        {
            Console.Write('|');
        }
        for (int i = 0; i < dotsm; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < slash; i++)
        {
            Console.Write('\\');
        }
        for (int i = 0; i < dotsr; i++)
        {
            Console.Write('.');
        }
        Console.WriteLine();
    }

    private static void DrawLine(int dotsl, int slash, int dotsn, int vertical, int dotsm, int backsclash, int dotsr)
    {
        for (int i = 0; i < dotsl; i++)
			{
                Console.Write('.');
			}
        for (int i = 0; i < backsclash; i++)
        {
            Console.Write('\\');
        }
        for (int i = 0; i < dotsn; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < vertical; i++)
        {
            Console.Write('|');
        }
        for (int i = 0; i < dotsm; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < slash; i++)
        {
            Console.Write('/');
        }
        for (int i = 0; i < dotsr; i++)
        {
            Console.Write('.');
        }
        Console.WriteLine();
    }
}

