using System;

class Sunglasses
{
    static void Main()
    {
        int n = 5;
        int asterixl = 1;
        int asterixr = 1;
        int asterixes = 2 * 5;
        int empty = n;
        int slash = n * 2 - 2;
        int vertical = n;
        int asterixesl = 1;
        int slashes = n * 2 - 2;
        int asterixesr = 1;
        Console.WriteLine(new String('*', 2 * n) + new String(' ', n) + new String('*', 2 * n));
        for (int i = 0; i < n-2; i++)
        {
            DrawLine(asterixl, slash, asterixr, empty, asterixesl, slashes, asterixesr);
            Console.WriteLine();
            
        }
        Console.WriteLine(new String('*', 2 * n) + new String(' ', n) + new String('*', 2 * n));

    }

    private static void DrawLine(int asterixl, int slash, int asterixr, int empty, int asterixesl, int slashes, int asterixesr)
    {
        for (int i = 0; i < asterixl; i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < slash; i++)
        {
            Console.Write('/');
        }
        for (int i = 0; i < asterixr; i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < empty; i++)
        {
            Console.Write(' ');
        }
        for (int i = 0; i < asterixesl; i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < slashes; i++)
        {
            Console.Write('/');
        }
        for (int i = 0; i < asterixesr; i++)
        {
            Console.Write('*');
        }
    }
}

