using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient
{
    using ServiceClient.ServiceReferenceCalculator;

    class Program
    {
        static void Main(string[] args)
        {
            var service = new CalculatorClient();
            Point a = new Point(){X = 4,Y=5};
            Point b = new Point(){X = 2, Y = 3};
            
            Console.WriteLine(string.Format("the distance is {0:0.00}", service.CalcDistance(a, b)));

        }
    }
}
