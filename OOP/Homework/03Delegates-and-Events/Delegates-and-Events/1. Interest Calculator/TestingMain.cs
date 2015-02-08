using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Interest_Calculator
{
    class TestingMain
    {
        public static decimal GetSimpleInterest(decimal money, decimal interest, int years)
        {
            return money * (1 + (interest / 100) * years);
        }
        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + (interest / 100) / 12), 12 * years);
        }

        static void Main()
        {
            InterestCalculator simple = new InterestCalculator(500m, 5.6m, 10, GetCompoundInterest);
            Console.WriteLine(simple);
            InterestCalculator compoundInterest = new InterestCalculator(2500m, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine(compoundInterest);
        }
    }
}
