using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMountains
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    using global::CodeFirstMountains.Migrations;

    class CodeFirstMountains
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MountainsContext, MountainsDatabaseMigrationConfiguration>());

            var context = new MountainsContext();
            foreach (var mountain in context.Mountains)
            {
                Console.WriteLine(mountain.Name);
            }
        }
    }
}
