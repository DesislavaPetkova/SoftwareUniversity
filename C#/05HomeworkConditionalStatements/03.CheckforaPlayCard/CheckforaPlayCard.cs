using System;

class CheckforaPlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter your string here (Use capital letters or numbers): ");
        string card = Console.ReadLine();
        if (card == "2" || card == "3" || card == "4" || card == "5" || card == "6" || card == "7" || card == "8" || card == "9" || card == "10" || card == "J" || card == "Q" || card == "K" || card == "A")
        {
            Console.WriteLine("YES");
        }
        else 
        {
            Console.WriteLine("No");
        }
    }
}

