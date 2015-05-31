namespace Twitter.Web.Controllers
{
    using System;
    using System.Web.Mvc;

    using Twitter.Data;
    using Twitter.Data.Controllers;
    using Twitter.Models;

    public class TweetsController : BaseController
    {
        TwitterDbContext db = new TwitterDbContext();

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(TweetViewModel tweet)
        {
            var newTweet = new Tweet();
            //newTweet.Title = tweet.Title;
            newTweet.Text = tweet.Text;
            //newTweet.URL = tweet.URL;
            newTweet.Date = DateTime.Now;
            newTweet.UserId = this.UserProfile.Id;
            if (newTweet.UserId == null)
            {
                return this.RedirectToAction("ErrorCreation");
            }
            this.db.Tweets.Add(newTweet);
            this.db.SaveChanges();
            
            return this.RedirectToAction("SuccessCreated");

        }

//        public ActionResult Index()
//        {
//            return this.RedirectToRoute("~home/index");
//        }
        public ActionResult SuccessCreated()
        {
            return this.View();
        }

        public ActionResult ErrorCreation()
        {
            return this.View();
        }
    }
}