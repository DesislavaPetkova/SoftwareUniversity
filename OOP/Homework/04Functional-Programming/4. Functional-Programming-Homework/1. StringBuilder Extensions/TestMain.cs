using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StringBuilder_Extensions
{
    class TestMain
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder();
            test.Append("wqewe ewqewq qrqwe");
            Console.WriteLine(test.Substring(2, 5));
            Console.WriteLine(test.RemoveText("qrq"));
        }
    }
}
