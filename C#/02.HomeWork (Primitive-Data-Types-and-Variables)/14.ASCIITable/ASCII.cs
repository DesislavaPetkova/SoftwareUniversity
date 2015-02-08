using System;
using System.Text;

class ASCII
{
    static void Main()
    {
        for (int sym = 0; sym < 256; sym++)
            Console.WriteLine(sym + "--->" + (char)sym + "---> in ASCII");
    }
}

