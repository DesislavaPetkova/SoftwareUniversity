using System;

class PlaywithIntDoubleandString
{
    static void Main()
    {
        Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string
");
        string type = Console.ReadLine();
        switch (type)
        {
            default:
                Console.WriteLine("Choose again (1 2 or 3)");
                break;
            case "1":
                Console.WriteLine("Please enter an int: ");
                int case1 = int.Parse(Console.ReadLine());
                Console.WriteLine(case1 + 1);
                break;
            case "2":
                Console.WriteLine("Please enter a double: ");
                double case2 = double.Parse(Console.ReadLine());
                Console.WriteLine(case2 +1);
                break;
            case "3":
                Console.WriteLine("Please enter a string");
                string case3 = Console.ReadLine();
                Console.WriteLine(case3 + "*");
                break;
        }
            
    }
}

