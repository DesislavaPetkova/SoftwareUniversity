using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Twitter.Data.Migrations;
using Twitter.Models;

namespace Twitter.Data
{
    public class TwitterDbContext : IdentityDbContext<User>, ITwitterDbContext
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

        public IDbSet<Tweet> Tweets { get; set; }
        public IDbSet<Report> Reports { get; set; }
        public IDbSet<Profile> Profiles { get; set; }
        public IDbSet<Notification> Notifications { get; set; }
        public IDbSet<Message> Messages { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

//            modelBuilder.Entity<User>()
//                .HasMany(x => x.Followers).WithMany()
//                .Map(x => x.ToTable("User_Followers"));
//
//            modelBuilder.Entity<User>().HasMany(x => x.Following).WithMany()
//                .Map(x => x.ToTable("User_Following"));

            modelBuilder.Entity<User>()
                .HasMany(u => u.Followers)
                .WithMany()
                .Map(x =>
                {
                    x.MapLeftKey("UserId");
                    x.MapRightKey("FollowerId");
                    x.ToTable("UsersToFollowers");
                });

            modelBuilder.Entity<User>()
                .HasMany(u => u.Following)
                .WithMany()
                .Map(x =>
                {
                    x.MapLeftKey("UserId");
                    x.MapRightKey("FollowingId");
                    x.ToTable("UsersToFollowings");
                });

            modelBuilder.Entity<User>()
                .HasMany(u => u.FavoriteTweets)
                .WithMany(u => u.FavoriteByUsers)
                .Map(x =>
                {
                    x.MapLeftKey("UserId");
                    x.MapRightKey("TweetId");
                    x.ToTable("UsersToFavoritedTweets");
                });
            

            modelBuilder.Entity<Message>()
                        .HasRequired(m => m.OwnerUser)
                        .WithMany(t => t.OwnerMessages)
                        .HasForeignKey(m => m.OwnerId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Message>()
                        .HasRequired(m => m.RecipientUser)
                        .WithMany(t => t.RecipientMessages)
                        .HasForeignKey(m => m.RecipientId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            
        }
    }
}
