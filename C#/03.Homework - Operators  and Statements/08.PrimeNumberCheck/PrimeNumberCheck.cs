using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Type your number and if its Prime your result will be True");
        int number = int.Parse(Console.ReadLine());
        bool devidebytwo = number % 2 == 0;
        bool devidebythree = number % 3 == 0;
        bool devidebyfive = number % 5 == 0;
        bool devidebyseven = number % 7 == 0;
        bool prime = (devidebytwo == false && devidebythree == false && devidebyfive == false && devidebyseven == false) || (number == 2) || (number == 3) || (number == 5) || (number == 7);
        Console.WriteLine("Your number {0} is prime : {1}", number, prime);
        
    }   
}

