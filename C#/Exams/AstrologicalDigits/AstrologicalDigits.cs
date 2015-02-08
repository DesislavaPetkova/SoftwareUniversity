using System;
using System.Linq;

class AstrologicalDigits
{
    static void Main()
    {
        string n = Console.ReadLine();
        int sum = 0;
        while (true)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '.' || n[i] == '-')
                {
                    continue;
                }
                sum = sum + int.Parse(n[i].ToString());
            }          
            
            if (sum < 10)
            {
                break;
            }
            n = sum.ToString();
            sum = 0;
        }
        Console.WriteLine(sum);
    }

}


