using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{
    class TestMain
    {
        private static void Main()
        {
            StringDisperser testOne = new StringDisperser("gosho", "pesho", "ivan");
            StringDisperser testTwo = new StringDisperser("gosho", "pesho", "ivwn");

            if (testOne.Equals(testTwo))
            {
                Console.WriteLine("raboti");
            }
            else
            {
                Console.WriteLine("NE");
            }

            Console.WriteLine(testTwo);
            foreach (var ch in testOne)
            {
                Console.Write(ch + " ");
            }
        }
    }
}
