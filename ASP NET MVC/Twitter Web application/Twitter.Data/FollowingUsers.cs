namespace Twitter.Data
{
    using System.Collections.Generic;

    public class FollowingUsers
    {

        public FollowingUsers()
        {
            this.Followers = new HashSet<User>();
            this.Followered = new HashSet<User>();
        }
        public int Id { get; set; }
        public string FollowerId { get; set; }

        public string FolloweredId { get; set; }

        public virtual ICollection<User> Followers { get; set; }

        public virtual ICollection<User> Followered { get; set; }
    }
}
