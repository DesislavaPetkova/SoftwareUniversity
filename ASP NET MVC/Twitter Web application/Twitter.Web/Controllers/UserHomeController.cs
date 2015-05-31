namespace Twitter.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using PagedList;

    using Twitter.Data;
    using Twitter.Models;
    [Route("UserHome")]
    public class UserHomeController : BaseController
    {
        private TwitterDbContext db = new TwitterDbContext();

        // GET: UserHome
        
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var isLogged = this.HttpContext.User.Identity.IsAuthenticated;
            if (isLogged)
            {
                var userId = this.UserProfile.Id;
                var followereds = this.db.FollowingUsers.Where(f => f.FollowerId == userId).Select(f => f.FolloweredId);

                var homeTweets =
                    this.db.Tweets.OrderByDescending(d => d.Date)
                        .ThenBy(d => d.Title)
                        .Where(d => followereds.Contains(d.UserId))
                        .Select(TweetViewModel.ViewModel);

                PagedList<TweetViewModel> modelView = new PagedList<TweetViewModel>(homeTweets, page, pageSize);
                return this.View("UserHome", modelView);
            }
            else
            {
                return this.RedirectToRoute("index");
            }
        }

        public ActionResult Create()
        {
           return this.RedirectToActionPermanent("Create", "Tweets");
        }
    }
}