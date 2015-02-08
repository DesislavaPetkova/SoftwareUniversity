using System;

class DiamondTrolls
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2) * 3; 
        int asterix = 1;
        int asterixes = 1;
        int asteriks = 1;
        int dotsl = (width - 3) / 4;
        int dotsr = (width - 3) / 4;
        int dotsn = (width - 3) / 4;
        int dotsm = (width - 3) / 4;
        int dotstopl = ((n * 2 + 1) - n) / 2;
        int dotstopr = ((n * 2 + 1) - n) / 2;
        Console.WriteLine(new String ('.',dotstopl) + new String('*', n) + new String ('.', dotstopr));
        while (true)
        {
            DrawLine(dotsl, asterix, dotsn, asterixes, dotsm, asteriks, dotsr);
            Console.WriteLine();
            dotsl--;
            dotsr--;
            dotsn++;
            dotsm++;
        
            if (dotsl <= 0)
            {
             break;
            }
        }
        Console.WriteLine(new String ('*', width));
        dotsl = 1;
        dotsr = 1;
        dotsn = ((width - 3)- 2) / 2;
        dotsm = ((width - 3)- 2) / 2;
        while (true)
        {
            DrawLine(dotsl, asterix, dotsn, asterixes, dotsm, asteriks, dotsr);
            Console.WriteLine();
            dotsl++;
            dotsr++;
            dotsn--;
            dotsm--;

            if (dotsn <= -1)
            {
                break;
            }
        }
            Console.WriteLine(new String('.', n) + new String('*', 1) + new String('.', n));
    }

    private static void DrawLine(double dotsl, int asterix, double dotsn, int asterixes, double dotsm, int asteriks, double dotsr)
{
 	for (int i = 0; i < dotsl; i++)
			{
			 Console.Write('.');
			}
    for (int i = 0; i < asterix; i++)
			{
			 Console.Write('*');
			}
    for (int i = 0; i < dotsn; i++)
			{
			 Console.Write('.');
			}
    for (int i = 0; i < asterixes; i++)
			{
			 Console.Write('*');
			}
    for (int i = 0; i < dotsm; i++)
			{
			 Console.Write('.');
			}
    for (int i = 0; i < asteriks; i++)
			{
			 Console.Write('*');
			}
    for (int i = 0; i < dotsr; i++)
			{
			 Console.Write('.');
			}
}
}

