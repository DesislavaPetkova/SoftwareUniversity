using System;
using System.Linq;

class OddandEvenProduct
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] splitted = numbers.Split(' ');
        int odd = 1;
        int even = 1;
        for (int i = 0; i < splitted.Length; i++)
        {
            int raboten = int.Parse(splitted[i]);
            bool isodd = ((i % 2) != 0);
            bool iseven = ((i % 2) == 0);
            if (isodd)
            {
                odd *= raboten;
            }
            else if (iseven)
            {
                even *= raboten;
            }
        }
        if (odd == even)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", odd);
            }
        else 
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", odd);
                Console.WriteLine("even_product = {0}", even);
            }
        
    }
}

