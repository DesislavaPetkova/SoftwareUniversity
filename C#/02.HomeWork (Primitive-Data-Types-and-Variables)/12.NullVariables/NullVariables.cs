using System;

class NullVariables
{
    static void Main()
    {
        int? nullint = null;
        double? doublenull = null;
        Console.WriteLine("Null int = {0}, Double null =  {1}", nullint, doublenull);
        Console.WriteLine(nullint + 234);
        Console.WriteLine(doublenull + 1231432d);
        int? nullvalues = 123;
        double? doublevalues = 23332;
        Console.WriteLine("Values inside null variables: {0}, {1}", nullvalues, doublevalues);
        int sum = 232;
        Console.WriteLine(nullint + sum);
        Console.WriteLine((sum + nullvalues)*2);
    }
}

