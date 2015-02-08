using System;
using System.Text;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
 
class IsoscelesTriangle
{
    static void Main()
    {       
        Console.OutputEncoding = Encoding.UTF8;
        char copy = '\u00A9';
        int spaceLeft = 2;
        int copyl = 1;
        int copyr = 1;
        int spaceMid = 1;
        int spaceRight = 2;



        Console.WriteLine(new string(' ', 3) + new string(copy, 1) + new string(' ', 3));
        while (true)
        {
            if (spaceLeft == 0)
            {
                break;
            }
            DrawLine(spaceLeft, copyl, spaceMid, copyr, spaceRight);
            spaceLeft--;
            spaceMid+= 2;
            spaceRight--;
            Console.WriteLine();
        }
        Console.WriteLine(new string('\u00A9', 1) + " " + new string('\u00A9', 1) + " " + new string('\u00A9', 1) + " " + new string('\u00A9', 1));
    }

    private static void DrawLine(int spaceLeft, int copyl, int spaceMid, int copyr, int spaceRight)
    {
        for (int i = 0; i < spaceLeft; i++)
        {
            Console.Write(' ');
        }
        for (int i = 0; i < copyl; i++)
        {
            Console.Write('\u00A9');
        }
        for (int i = 0; i < spaceMid; i++)
        {
            Console.Write(' ');
        }
        for (int i = 0; i < copyr; i++)
        {
            Console.Write('\u00A9');
        }
        for (int i = 0; i < spaceRight; i++)
        {
            Console.Write(' ');
        }
    }
}

