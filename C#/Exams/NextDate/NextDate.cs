using System;
using System.Globalization;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
       
        DateTime dt = new DateTime(year, month, day);        
        dt = dt.AddDays(1);
        Console.WriteLine(dt.ToString("d.M.yyyy"));

    }
}

