namespace Twitter.Web.Controllers
{
    using System;
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity;

    using Twitter.Data;
    using Twitter.Models;

    public class TweetsController : Controller
    {
        TwitterDbContext db = new TwitterDbContext();

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(TweetInputModels tweet)
        {
            var newTweet = new TweetModel();
            newTweet.Title = tweet.Title;
            newTweet.Text = tweet.Text;
            newTweet.URL = tweet.URL;
            newTweet.Date = DateTime.Now;
            newTweet.UserId = this.HttpContext.User.Identity.GetUserId();

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
    }
}