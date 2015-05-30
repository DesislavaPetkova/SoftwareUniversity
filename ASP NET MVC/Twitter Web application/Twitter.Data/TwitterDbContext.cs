namespace Twitter.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;

    using System.Data.Entity;

    using Twitter.Data;

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
