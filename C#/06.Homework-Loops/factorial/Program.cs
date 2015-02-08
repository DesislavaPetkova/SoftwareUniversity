using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main()
        {
            int a = 5;

            Console.WriteLine(factorial(a));
        }
        public static long factorial(int n)
        {
            // The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            else
            {
                return n * factorial(n - 1);
            }
        }
    }
}
