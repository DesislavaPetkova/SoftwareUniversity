using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportInternationalMatchesasXML
{
    using System.Xml.Linq;

    using EntityFrameworkMappings;

    class ExportInternationalMatchesasXML
    {
        static void Main(string[] args)
        {
            var context = new FootballEntities();
            var intMatchesQueary =
                context.InternationalMatches.OrderBy(m => m.MatchDate)
                    .ThenBy(m => m.HomeCountry)
                    .ThenBy(m => m.AwayCountry)
                    .Select(m => new
                    {
                        homeCountry = m.HomeCountry.CountryName,
                        homeCode = m.HomeCountryCode,
                        awayCountry = m.AwayCountry.CountryName,
                        awayCode = m.AwayCountryCode,
                        league = m.League.LeagueName,
                        date = m.MatchDate,
                        homeGoals = m.HomeGoals,
                        awayGoals = m.AwayGoals
                    });


            var xmlDoc = new XDocument();
            var xmlRoot = new XElement("matches");
            xmlDoc.Add(xmlRoot);

            foreach (var match in intMatchesQueary)
            {
                

                XElement matchXml;
                
                if (match.date != null)
                {
                    if (match.date.Value.TimeOfDay == TimeSpan.Zero)
                    {
                        matchXml = new XElement("match", new XAttribute("date-time", match.date.Value.ToString("dd-MMM-yyyy")));
                        xmlRoot.Add(matchXml);
                    }
                    else
                    {
                        matchXml = new XElement("match", new XAttribute("date", match.date.Value.ToString("dd-MMM-yyyy") + " " + match.date.Value.ToString("hh:mm")));
                        xmlRoot.Add(matchXml); 
                    }
                }
                else
                {
                    matchXml = new XElement("match");
                    xmlRoot.Add(matchXml);
                }
                
                var homeCountryXml = new XElement("home-country", match.homeCountry, new XAttribute("code", match.homeCode));
                matchXml.Add(homeCountryXml);
                var awayCountryXml = new XElement("away-country", match.awayCountry, new XAttribute("code", match.awayCode));
                matchXml.Add(awayCountryXml);
                if (match.league != null)
                {
                    var leagueXml = new XElement("league", match.league);
                    matchXml.Add(leagueXml);
                }
                if(match.homeGoals != null)
                {
                    var scoreXml = new XElement("score", match.homeGoals + "-"+ match.awayGoals);
                    matchXml.Add(scoreXml);
                }


            }
            Console.WriteLine(xmlDoc);
            xmlDoc.Save("matches.xml");

        }
    }
}
