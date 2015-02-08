using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class TestingMain
    {
        static void Main()
        {
            GenericList<int> listInt = new GenericList<int>(6);
            listInt.Add(2);
            listInt.Add(5);
            listInt.Add(12);
            listInt.Add(65);
            listInt.Add(78);
            listInt.Add(23);
            listInt.Insert(22323, 2);

            Console.WriteLine(listInt.Min());
            
        }
    }
}
