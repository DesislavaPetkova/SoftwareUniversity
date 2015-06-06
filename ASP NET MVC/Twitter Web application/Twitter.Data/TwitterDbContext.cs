namespace Twitter.Data
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;

    using Twitter.Models;
    using Twitter.Web;
    using Twitter.Web.Migrations;

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

        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<FollowingUsers> FollowingUsers { get; set; }
            
        
    }
}
