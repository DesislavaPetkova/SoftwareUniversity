using System.Data.Entity;
using Twitter.Models;

namespace Twitter.Data
{
    public interface ITwitterDbContext
    {
        IDbSet<Tweet> Tweets { get; set; }

        IDbSet<Report> Reports { get; set; }

        IDbSet<Profile> Profiles { get; set; }
        IDbSet<Notification> Notifications { get; set; }

        IDbSet<Message> Messages { get; set; }  
        

        int SaveChanges();
    }
}
    