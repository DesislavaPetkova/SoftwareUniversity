namespace Twitter.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using PagedList;
    using Twitter.Data;
    using Twitter.Models;

    public class HomeController : Controller
    {
        private TwitterDbContext db = new TwitterDbContext();

        public ActionResult Index(int page = 1, int pageSize = 9)
        {

            var homeTweets = this.db.Tweets
                .OrderByDescending(d => d.Date)
                .ThenBy(d => d.Title)
                .Where(d => d.UserFavList.Contains(d.User))
                .Select(TweetViewModel.ViewModel);

            PagedList<TweetViewModel> model = new PagedList<TweetViewModel>(homeTweets, page, pageSize);

            return this.View(model);
        }

        
    }
}