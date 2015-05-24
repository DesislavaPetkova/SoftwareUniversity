namespace Twitter.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Twitter.Data;
    using Twitter.Web;

    public class HomeController : Controller
    {
        private TwitterDbContext db = new TwitterDbContext();
        public ActionResult Index()
        {
            var homeTweets = this.db.Tweets.Select(x => new
                {
                    Title = x.Title,
                    Content = x.Text,
                    PostedBy = x.User.UserName,
                    DatePosted = x.Date,
                    
                })
                .OrderByDescending( d => d.DatePosted)
                .ThenBy(d => d.Title)
                .ToList();
            
            
            return View();
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