namespace Twitter.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity;

    using PagedList;

    using Twitter.Web.Models;

    [Route("UserHome")]
    public class UserHomeController : BaseController
    {
        

        // GET: UserHome
        [Authorize]
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
                
                var userId = this.HttpContext.User.Identity.GetUserId();
                var followereds = this.Db.FollowingUsers.Where(f => f.FollowerId == userId).Select(f => f.FolloweredId);

                var homeTweets =
                    this.Db.Tweets.OrderByDescending(d => d.Date)
                        .ThenBy(d => d.Title)
                        .Where(d => followereds.Contains(d.UserId))
                        .Select(TweetViewModel.ViewModel);

                PagedList<TweetViewModel> modelView = new PagedList<TweetViewModel>(homeTweets, page, pageSize);
                return this.View("UserHome", modelView);
            
        }

        public ActionResult Create()
        {
           return this.RedirectToActionPermanent("Create", "Tweets");
        }
    }
}