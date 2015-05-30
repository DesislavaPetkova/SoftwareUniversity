using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    using System.Linq.Expressions;

    using Twitter.Data;

    public class TweetViewModel
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public string URL { get; set; }

        public DateTime Date { get; set; }

        public string User { get; set; }

        public static Expression<Func<TweetModel, TweetViewModel>> ViewModel
        {
            get
            {
                return t => new TweetViewModel()
                {
                    Title = t.Title,
                    Text = t.Text,
                    Date = t.Date,
                    User = t.User.UserName
                };
            }
        }

        public IEnumerable<TweetViewModel> AllTweets { get; set; }


    }
}
