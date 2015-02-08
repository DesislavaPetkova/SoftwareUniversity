using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Asynchronous_Timer
{
    class TestingMain
    {
        
        
        static void Main()
        {
            Action<int> firstTest = (num) => Console.WriteLine("I am the first test.Timer:{0}", num);
            Action<int> secondTest = (num) => Console.WriteLine("I am the second test.Timer:{0}", num);

            // create two Asynchtimers
            var firstTimer = new AsynchronousTimer(firstTest, 10, 500);
            var secondTimer = new AsynchronousTimer(secondTest, 5, 1000);

            //run the tests
            firstTimer.Run();
            secondTimer.Run();
        }

    }
}
