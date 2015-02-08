using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Type an integer (0 ≤ a ≤ 500)");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Type two floating-points");
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        string hack = String.Empty;
        // Old shit
       // Console.Write("|{0:X}      |", a);
       // Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
       // Console.Write("|");
        //Console.Write("    ");
       // Console.Write("{0,2:0.00}|", b);
       // Console.WriteLine("{0,-2:0.000}   |", c);
        Console.WriteLine("|{0:X}{1, 10}|{2}|{1, -6}{3,10:0.00}|{4,-5:0.000}{1, 10}|", a, hack, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}

