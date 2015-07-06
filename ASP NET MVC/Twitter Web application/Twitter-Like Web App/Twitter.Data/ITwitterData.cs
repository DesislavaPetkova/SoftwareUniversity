using Twitter.Data.Repositories;
using Twitter.Models;

namespace Twitter.Data
{
    public interface ITwitterData
    {
        IRepository<User> Users { get; }
        IRepository<Tweet> Tweets { get; }
        IRepository<Report> Reports { get; }
        IRepository<Profile> Profiles { get; }
        IRepository<Notification> Notifications { get; }
        IRepository<Message> Messages{ get; }
        IRepository<User> UsersToFollowers { get; }
        IRepository<User> UsersToFollowings { get; }    

        int SaveChanges();
    }
}
