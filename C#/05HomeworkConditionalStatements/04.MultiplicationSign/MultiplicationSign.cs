using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers: ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        //float result = a * b * c;
        bool checka = (a < 0);
        bool checkb = (b < 0);
        bool checkc = (c < 0);
        float zero = 0;
        bool zerocheck = ((a != 0) && (b != 0) && (c != 0));
        if ((checka == false) ^ (checkb == false) ^ (checkc == false))
        {
            Console.WriteLine("+");
        }
        if (((checka == true) ^ (checkb == true) ^ (checkc == true)) && (zerocheck == true))
        {
            Console.WriteLine("-");
        }
        else if ((checka == true) && (checkb == true) && (checkc == true))      
        {
            Console.WriteLine("-");
        }
        if ((a == zero) || (b == zero) || (c == zero))
        {
            Console.WriteLine("0");
        }
    }
}

