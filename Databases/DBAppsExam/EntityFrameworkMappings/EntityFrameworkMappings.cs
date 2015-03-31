using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMappings
{
    class EntityFrameworkMappings
    {
        static void Main(string[] args)
        {
            var context = new FootballEntities();
            foreach (var team in context.Teams)
            {
                Console.WriteLine(team.TeamName);
            }
            
        }
    }
}
