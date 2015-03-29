namespace ExportRiversAsJson
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Script.Serialization;
    using Ef_Mapping;

    class ExportsRiversAsJson
    {
        static void Main()
        {
            var context = new GeographyEntities();
            var rivers = context.Rivers;
            var riversQuery = rivers
                .OrderByDescending(r => r.Length)
                .Select( r=> new
                    {
                        riverName = r.RiverName,
                        riverLength = r.Length,
                        countries = r.Countries
                        .OrderBy(c => c.CountryName)
                        .Select(c=> c.CountryName)
                    });

            //Console.WriteLine(riversQuery);
            var json = new JavaScriptSerializer().Serialize(riversQuery);
            Console.WriteLine(json);
            File.WriteAllText("rivers.json", json);

        }
    }
}
