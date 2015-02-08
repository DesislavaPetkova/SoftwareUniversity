using System;

class Quoting
{
    static void Main()
    {
        string ab = "The \"use\" of quotations causes difficulties.";
        string bb = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(ab);
        Console.WriteLine(bb);
    }
}

