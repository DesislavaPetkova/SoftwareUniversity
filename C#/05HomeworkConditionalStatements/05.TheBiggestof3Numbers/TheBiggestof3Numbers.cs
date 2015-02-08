using System;

class TheBiggestof3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        bool check = (a > b);
        bool check2 = (a > c);
        bool check3 = (b > c);
        bool check4 = (b > a); 
        if ((check == true) && (a > c))
        {
            Console.WriteLine(a);
        }
        else if (check2 == true)
        {
            Console.WriteLine(a);
        }
        else if (check4 == true)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

