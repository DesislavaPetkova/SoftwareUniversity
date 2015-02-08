using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Gradev";
        int age = 25;
        string gender = "male";
        long personalID = 8306112507;
        ulong uniqueID = 2756000012327569999;

        Console.WriteLine(@"First name: {0}
Last Name: {1}
Age: {2}
Gender: {3}
Personal ID Number: {4}
Unique employee number: {5}", firstName, lastName, age, gender, personalID, uniqueID);
    }
}

