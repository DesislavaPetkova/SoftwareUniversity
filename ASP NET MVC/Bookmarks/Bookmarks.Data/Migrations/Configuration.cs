namespace Bookmarks.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookmarksDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.ContextKey = "Bookmarks.Data.ApplicationDbContext";
            this.AutomaticMigrationDataLossAllowed = false;
        }
    }
}
