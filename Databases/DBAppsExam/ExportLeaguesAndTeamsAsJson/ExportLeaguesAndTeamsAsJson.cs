using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportLeaguesAndTeamsAsJson
{
    using System.IO;
    using System.Web.Script.Serialization;

    using EntityFrameworkMappings;

    class ExportLeaguesAndTeamsAsJson
    {
        static void Main(string[] args)
        {
            var context = new FootballEntities();
            var exportQuery = context.Leagues
                .OrderBy(l => l.LeagueName)
                .Select(l => new
                {
                    leagueName  = l.LeagueName,
                    teams = l.Teams.OrderBy(t => t.TeamName)
                    .Select(t => t.TeamName)                                 
                });

            var json = new JavaScriptSerializer().Serialize(exportQuery);
            //Console.WriteLine(json);

            File.WriteAllText("leaguesAndTeams.json", json);


        }
    }
}
