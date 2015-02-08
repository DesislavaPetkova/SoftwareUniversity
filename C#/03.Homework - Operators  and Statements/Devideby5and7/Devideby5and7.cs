using System;

class Devideby5and7
{
    static void Main()
    {
        Console.WriteLine("Type here your number:  ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number % 5 == 0 && number % 7 ==0 ? true : false);
                  
    }
}

