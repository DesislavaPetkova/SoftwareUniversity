namespace Twitter.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using PagedList;

    using Twitter.Web.Models;

    public class HomeController : BaseController
    {
        

        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var user = this.HttpContext.User.Identity.IsAuthenticated;
            if (user)
            {
                return this.RedirectToActionPermanent("Index", "UserHome");
            }

            var homeTweets = this.Db.Tweets
                .OrderByDescending(d => d.Date)
                .ThenBy(d => d.Title)
                .Select(TweetViewModel.ViewModel);

            PagedList<TweetViewModel> model = new PagedList<TweetViewModel>(homeTweets, page, pageSize);
            return this.View(model);
        }
    }
}
