using System;
using System.Linq;
class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());        
        
        int cs = 0;
        int[] result = new int[11];
        for (int i = 0; i < n; i++)
        {            
            int cats = int.Parse(Console.ReadLine());
            for (int t = 0; t < 1; t++)
            {
                result[cats]++;
            }
            cs = result.Max();    
        }
        int check = int.MinValue;
        for (int i = 1; i < 11; i++)
        {
            if (result[i] == cs)
            {
                check = i;
                break;
            }
        }
        Console.WriteLine(check);
    }    
}

