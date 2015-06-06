namespace Twitter.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using Twitter.Models;

    public class UserHomeModels
    {
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string User { get; set; }

        public IEnumerable<TweetViewModel> AllTweets { get; set; }
        public static Expression<Func<Tweet, UserHomeModels>> ViewModel
        {
            get
            {
                return t => new UserHomeModels()
                {
                    Text = t.Text,
                    Date = t.Date,
                    User = t.User.UserName
                };
            }
        }
    }
}
