using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportMonaseriesAsXml
{
    using System.IO;
    using System.Xml.Linq;

    using Ef_Mapping;

    class Program
    {
        static void Main(string[] args)
        {
            var context = new GeographyEntities();
            var countriesQuery = context.Countries
                .Where(c => c.Monasteries.Any())
                .OrderBy(c => c.CountryName)
                .Select(c => new
                    {
                            countryName = c.CountryName,
                            monasteries = c.Monasteries
                            .OrderBy(m => m.Name)
                            .Select(m => m.Name)
                    });

            var xmlDoc = new XDocument();
            var xmlRoot = new XElement("monasteries");
            xmlDoc.Add(xmlRoot);

            foreach (var country in countriesQuery)
            {

                var countryXml = new XElement("country", new XAttribute("name", country.countryName));
                xmlRoot.Add(countryXml);

                foreach (var monastery in country.monasteries)
                {
                    var monasteryXml = new XElement("monastery", monastery);
                    countryXml.Add(monasteryXml);
                }
            }

            Console.WriteLine(xmlDoc);
            xmlDoc.Save("monasteries.xml");

        }
    }
}
