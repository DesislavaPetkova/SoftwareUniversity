using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = 2011;
        int firstdigit = number / 1000;
        int secondnumber = number / 10000;
        int thirdnumber = number % 10;
        int forthnumber = number / 10;
        int lastnumber = forthnumber % 10;

        Console.WriteLine(firstdigit + secondnumber + thirdnumber + lastnumber);
        Console.WriteLine("{0}{1}{2}{3}", lastnumber, thirdnumber, secondnumber, firstdigit);
        Console.WriteLine("{0}{1}{2}{3}", lastnumber, firstdigit, secondnumber, thirdnumber);
        Console.WriteLine("{0}{1}{2}{3}", firstdigit, thirdnumber, secondnumber, lastnumber);
    }
}

