using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PCCatalog
{
    class PcCatalog
    {
        static void Main()
        {
            Console.WriteLine("Enter pc Name");
            string name = "nasaPC";
            Computer nasaPC = new Computer(name, "Intel I7", 2312, "NVIDIA", 2132, "motherboard", 232);
            Console.WriteLine("Enter a price!");
            int price = 2000;
            
            
            Component VGA = new Component("graphicCard", (decimal)658, "nVIDIA");

            
            Console.WriteLine(nasaPC.ToString());

        }
    }
}
