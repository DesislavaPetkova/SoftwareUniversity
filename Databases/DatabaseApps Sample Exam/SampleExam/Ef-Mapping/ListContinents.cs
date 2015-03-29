using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Mapping
{
    class ListContinents
    {
        static void Main()
        {
            var context = new GeographyEntities();

            var continents = context.Continents;
            foreach (var continent in continents)
            {
                Console.WriteLine(continent.ContinentName);
            }
        }
    }
}
