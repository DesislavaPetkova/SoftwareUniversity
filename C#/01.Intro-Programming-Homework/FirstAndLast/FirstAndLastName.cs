using System;
class FirstAndLastName
    {
        static void Main()
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
    }
