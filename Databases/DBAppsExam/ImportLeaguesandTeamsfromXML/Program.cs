using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportLeaguesandTeamsfromXML
{
    using System.Xml.Linq;
    using System.Xml.XPath;

    using EntityFrameworkMappings;

    class Program
    {
        static void Main(string[] args)
        {
            var context = new FootballEntities();

            var xmlDoc = XDocument.Load("../../leagues-and-teams.xml");
            foreach (var leagueElement in xmlDoc.XPathSelectElements("/leagues-and-teams/league"))
            {
                
                if (leagueElement.Element("league-name") != null)
                {
                    var leagueNameCheck = leagueElement.Element("league-name").Value;
                    var leagueAvailable =
                        context.Leagues
                        .Where(l => l.LeagueName == leagueNameCheck)
                        .Select(l => l.LeagueName).ToList();

                    if (leagueAvailable.Count == 0)
                    {
                        var leagueEntity = new League();
                        leagueEntity.LeagueName = leagueElement.Element("league-name").Value;
                        context.Leagues.Add(leagueEntity);
                    }
                }

                
                if (leagueElement.Element("teams") != null)
                {
                    var teamName = leagueElement.Element("teams").Element("team").Attribute("name").Value;
                    var teamCountry = leagueElement.Element("teams").Element("team").Attribute("country").Value;

                    var teamExisting =
                        context.Teams.Where(t => t.TeamName == teamName && t.Country.CountryName == teamCountry)
                            .Select(t => t.TeamName)
                            .ToList();
                    if (teamExisting.Count == 0)
                    {
                        foreach (var teamElement in leagueElement.XPathSelectElements("teams/team"))
                        {
                            var teamEntity = new Team();
                            teamEntity.TeamName = teamElement.Attribute("name").Value;

                            if (teamElement.Attribute("country") != null)
                            {
                                var country = teamElement.Attribute("country").Value;

                                var countryCode = context.Countries
                                    .Where(c => c.CountryName == country)
                                    .Select(c => c.CountryCode).ToList();
                                teamEntity.CountryCode = countryCode[0];
                            }
                            context.Teams.Add(teamEntity);
                        }
                    }
                }
            }
            context.SaveChanges();
        }
    }
}
