namespace Twitter.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;
    using Twitter.Models;
    using System.Data.Entity;
    public class TwitterDbContext : IdentityDbContext<User>
    {
        public TwitterDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TwitterDbContext, Configuration>());
        }

        public static TwitterDbContext Create()
        {
            return new TwitterDbContext();
        }
    }
}
