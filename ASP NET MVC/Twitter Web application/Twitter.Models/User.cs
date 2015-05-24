namespace Twitter.Models
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public User()
        {
            this.Followers = new HashSet<User>();
            this.FollowingList = new HashSet<User>();
            this.Tweets = new HashSet<TweetModel>();
            this.FavTweets = new HashSet<TweetModel>();



        }

        public virtual ICollection<User> Followers { get; set; }

        public virtual ICollection<User> FollowingList { get; set; }

        public virtual ICollection<TweetModel> Tweets { get; set; }

        public virtual ICollection<TweetModel> FavTweets { get; set; }

        public int ProfileId { get; set; }
        
        public  virtual Profile Profile { get; set; }


    
        
    
    }
}
