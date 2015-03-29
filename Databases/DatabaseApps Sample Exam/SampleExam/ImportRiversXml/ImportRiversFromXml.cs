using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportRiversXml
{
    using System.Xml.Linq;
    using System.Xml.XPath;

    using Ef_Mapping;

    class ImportRiversFromXml
    {
        static void Main(string[] args)
        {
            var context = new GeographyEntities();
            var xmlDoc = XDocument.Load("../../rivers.xml");
            foreach (var riverElement in xmlDoc.XPathSelectElements("/rivers/river"))
            {
                var riverEntity = new River();
                riverEntity.RiverName = riverElement.Element("name").Value;
                riverEntity.Length = int.Parse(riverElement.Element("length").Value);
                riverEntity.Outflow = riverElement.Element("outflow").Value;

                if (riverElement.Element("drainage-area")!= null)
                {
                    riverEntity.DrainageArea = int.Parse(riverElement.Element("drainage-area").Value);
                }

                if (riverElement.Element("average-discharge") != null)
                {
                    riverEntity.AverageDischarge = int.Parse(riverElement.Element("average-discharge").Value);
                }

                ParseAddCountriestoRiver(riverElement, context, riverEntity);

                context.Rivers.Add(riverEntity);
            }

            context.SaveChanges();

        }

        private static void ParseAddCountriestoRiver(XElement riverElement, GeographyEntities context, River riverEntity)
        {
            var countryElements = riverElement.XPathSelectElements("countries/country");

            foreach (var countryElement in countryElements)
            {
                var countryName = countryElement.Value;
                var countryEntity = context.Countries.Where(c => c.CountryName == countryName).FirstOrDefault();

                if (countryEntity != null)
                {
                    riverEntity.Countries.Add(countryEntity);
                }
                else
                {
                    throw new Exception("No country");
                }
            }
        }
    }
}
