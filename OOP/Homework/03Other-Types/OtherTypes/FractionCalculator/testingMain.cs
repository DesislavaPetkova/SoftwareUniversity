using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class testingMain
    {
        static void Main()
        {
            Fraction f1 = new Fraction(22, 7);
            Fraction f2 = new Fraction(40, 4);
            Fraction result = f1 + f2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
