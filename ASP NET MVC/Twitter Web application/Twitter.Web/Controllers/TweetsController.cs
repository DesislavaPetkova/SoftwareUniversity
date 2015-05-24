namespace Twitter.Web.Controllers
{
    using System.Web.Mvc;
    using Twitter.Models;

    public class TweetsController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(TweetInputModels tweet)
        {
           
            return null;
            
        }

//        public ActionResult Index()
//        {
//            return this.RedirectToRoute("~home/index");
//        }
    }
}