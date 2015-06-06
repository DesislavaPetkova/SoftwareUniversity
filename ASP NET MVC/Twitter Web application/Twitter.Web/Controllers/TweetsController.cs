namespace Twitter.Web.Controllers
{
    using System;
    using System.Web.Mvc;


    using Twitter.Models;
    using Twitter.Web.Models;

    public class TweetsController : BaseController
    {
        

        [HttpGet]
        public ActionResult Create()
        {
            return this.View("_CreateTweetPartial");
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
            this.Db.Tweets.Add(newTweet);
            this.Db.SaveChanges();
            
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