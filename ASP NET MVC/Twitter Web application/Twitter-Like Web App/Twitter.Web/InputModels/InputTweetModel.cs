using System;
using Exam.Common.Mappings;
using Twitter.Models;

namespace Twitter.Web.InputModels
{
    public class InputTweetModel : IMapTo<Tweet>
    {
        public int Id { get; set; }
      
        public string Text { get; set; }

        public DateTime DatePosted { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string URL { get; set; }
    }
}