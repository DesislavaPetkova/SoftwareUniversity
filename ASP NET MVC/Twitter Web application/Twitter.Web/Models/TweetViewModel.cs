namespace Twitter.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using Twitter.Models;


    public class TweetViewModel
    {

        [Required]
        [MinLength(5)]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string User { get; set; }

        public static Expression<Func<Tweet, TweetViewModel>> ViewModel
        {
            get
            {
                return t => new TweetViewModel()
                {
                    Text = t.Text,
                    Date = t.Date,
                    User = t.User.UserName
                };
            }
        }

        public IEnumerable<TweetViewModel> AllTweets { get; set; }


    }
}
