namespace Twitter.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using PagedList;
    using Twitter.Data;
    using Twitter.Data.Controllers;
    using Twitter.Models;

    public class HomeController : BaseController
    {
        private TwitterDbContext db = new TwitterDbContext();

        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var isLogged = this.HttpContext.User.Identity.IsAuthenticated;
            if (isLogged)
            {
                var userId = this.UserProfile.Id;
                var followereds = this.db.FollowingUsers
                .Where(f => f.FollowerId == userId)
                .Select(f => f.FolloweredId);

                var homeTweets = this.db.Tweets
                    .OrderByDescending(d => d.Date)
                    .ThenBy(d => d.Title)
                    .Where(d => followereds.Contains(d.UserId))
                    .Select(TweetViewModel.ViewModel);

                PagedList<TweetViewModel> model = new PagedList<TweetViewModel>(homeTweets, page, pageSize);
                return this.View(model);
            }
            else
            {
                var homeTweets = this.db.Tweets
                    .OrderByDescending(d => d.Date)
                    .ThenBy(d => d.Title)
                    .Select(TweetViewModel.ViewModel);

                PagedList<TweetViewModel> model = new PagedList<TweetViewModel>(homeTweets, page, pageSize);
                return this.View(model);
            }
        }

        
    }
}