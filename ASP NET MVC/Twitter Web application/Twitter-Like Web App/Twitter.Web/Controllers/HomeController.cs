using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using PagedList;
using Twitter.Common;
using Twitter.Data;
using Twitter.Web.ViewModels;

namespace Twitter.Web.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController(ITwitterData data)
            :base(data)
        {
            
        }
        
        public ActionResult Index(int? page)
        {
            IQueryable<TweetViewModel> tweets;

            if (this.User.Identity.IsAuthenticated)
            {
                var currUser = this.Data
                    .Users
                    .All()
                    .Include(x => x.Following)
                    .Include("Following.Tweets")
                    .FirstOrDefault(u => u.Id == this.UserProfile.Id);
                tweets = currUser.Following
                    .SelectMany(f => f.Tweets)
                    .OrderByDescending(t => t.DatePosted)
                    .Take(10)
                    .AsQueryable()
                    .Project()
                    .To<TweetViewModel>();
                    

                 return View(tweets.ToPagedList(page ?? GlobalConstants.DefaultPageNumber, GlobalConstants.DefaultPageSize));
            }

            tweets = this.Data.Tweets
                .All()
                .OrderByDescending(x => x.DatePosted)
                .Take(10)
                .Project()
                .To<TweetViewModel>();

            
            return View(tweets.ToPagedList(page ?? GlobalConstants.DefaultPageNumber, GlobalConstants.DefaultPageSize)); //TODO: remove magic numbers and make them constants
        }
       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}