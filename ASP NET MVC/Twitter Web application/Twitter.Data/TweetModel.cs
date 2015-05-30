namespace Twitter.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tweet
    {
        private ICollection<User> userFavList;

        private ICollection<Tweet> tweetRepliesList;

        

        public Tweet()
        {
            this.userFavList = new HashSet<User>();
            this.tweetRepliesList = new HashSet<Tweet>();
        }


        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string URL { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }
        
        public virtual User User { get; set; }

        public ICollection<User> UserFavList
        {
            get
            {
                return this.userFavList;
            }
            set
            {
                this.userFavList = value;
            }
        }

        public ICollection<Tweet> TweetRepliesList
        {
            get
            {
                return this.tweetRepliesList;
            }
            set
            {
                this.tweetRepliesList = value;
            }
        }
        
    }
}
