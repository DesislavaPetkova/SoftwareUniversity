using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Twitter.Models
{
    public class User : IdentityUser
    {
        private ICollection<User> followers;
        private ICollection<User> following;
        private ICollection<Tweet> tweets;
        private ICollection<Message> ownerMessages;
        private ICollection<Tweet> favoriteTweets;
        private ICollection<Notification> notifications;
        private ICollection<Message> recipientMessages;
        

        public User()
        {
            this.Followers = new HashSet<User>();
            this.Following = new HashSet<User>();
            this.Tweets = new HashSet<Tweet>();
            this.OwnerMessages = new HashSet<Message>();
            this.FavoriteTweets = new HashSet<Tweet>();
            this.Notifications = new HashSet<Notification>();
            this.RecipientMessages = new HashSet<Message>();
        }
        

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<User> Followers
        {
            get { return followers; }
            set { followers = value; }
        }

        public virtual ICollection<User> Following  
        {
            get { return following; }
            set { following = value; }
        }

        public virtual ICollection<Tweet> Tweets
        {
            get { return tweets; }
            set { tweets = value; }
        }

        public virtual ICollection<Message> OwnerMessages
        {
            get { return ownerMessages; }
            set { ownerMessages = value; }
        }
        public ICollection<Message> RecipientMessages
        {
            get { return recipientMessages; }
            set { recipientMessages = value; }
        }
        public virtual ICollection<Tweet> FavoriteTweets
        {
            get { return this.favoriteTweets; }
            set { this.favoriteTweets = value; }
        }

        public ICollection<Notification> Notifications
        {
            get { return notifications; }
            set { notifications = value; }
        }

        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }


    }
}
