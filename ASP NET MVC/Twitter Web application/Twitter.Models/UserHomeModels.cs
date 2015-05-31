using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    using System.Linq.Expressions;

    using Twitter.Data;

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
