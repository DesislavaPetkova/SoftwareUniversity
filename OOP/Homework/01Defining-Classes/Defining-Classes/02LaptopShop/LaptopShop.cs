using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
   public class LaptopShop
    {
        static void Main()
        {
            Laptop firstLap = new Laptop("Lenovo Yoga 2 Pro", (decimal)2259.00);
            Battery lion = new Battery("Li-Ion, 4-cells, 2550 mAh");
            Battery nicd = new Battery("Ni-Cd", (float)4.5);
            Console.WriteLine(firstLap.ToString());
            Console.WriteLine();
            Laptop secondLap = new Laptop("Lenovo yoga", (decimal)2321, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", nicd);
            Console.WriteLine(secondLap.ToString());
            
            
        }
    }
}
