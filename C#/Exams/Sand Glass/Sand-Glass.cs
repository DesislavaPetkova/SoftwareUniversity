using System;

class Sand_Glass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int zvezda = n;
        int tochka = 0;
        while (true)
        {
            DrawLine(zvezda, tochka);
            zvezda = zvezda - 2;
            tochka++;
            Console.WriteLine();
            if (zvezda == -1)
            {
                break;
            }
        }
        zvezda = 3;
        tochka = (n - zvezda) / 2;
        while (true)
        {
            DrawLine(zvezda, tochka);
            zvezda = zvezda + 2;
            tochka--;
            Console.WriteLine();
            if (tochka == -1)
            {
                break;
            }
        }
    }

    private static void DrawLine(int zvezda, int tochka)
    {
        for (int i = 0; i < tochka; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < zvezda; i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < tochka; i++)
        {
            Console.Write('.');
        }
    }

  
}

