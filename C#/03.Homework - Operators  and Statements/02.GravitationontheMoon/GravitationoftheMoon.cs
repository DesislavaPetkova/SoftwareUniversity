using System;

class GravitationoftheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight when you are on Earth: ");
        float weight = float.Parse(Console.ReadLine());     
        float moon = weight * 0.17f;
        Console.WriteLine("Your Weight on the Moon will be: {0}", (float)moon);

    }
}

