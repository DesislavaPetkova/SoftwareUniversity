using System;
class SquareRoot
{
    static void Main()
    {
        Console.Write("Give me a number and i will return the square root of it: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(number));
    }
}
