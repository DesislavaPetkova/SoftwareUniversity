namespace Twitter.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TweetModel
    {
        private ICollection<User> userFavList;

        private ICollection<TweetModel> tweetRepliesList;

        

        public TweetModel()
        {
            this.userFavList = new HashSet<User>();
            this.tweetRepliesList = new HashSet<TweetModel>();
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

        public ICollection<TweetModel> TweetRepliesList
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
