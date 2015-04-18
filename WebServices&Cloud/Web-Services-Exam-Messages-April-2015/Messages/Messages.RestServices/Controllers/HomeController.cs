namespace Messages.RestServices.Models
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Redirect to Web API Help Page (Documentation)
            return this.Redirect("Help");
        }
    }
}
