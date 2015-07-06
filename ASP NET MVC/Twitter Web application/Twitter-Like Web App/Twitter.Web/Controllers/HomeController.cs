using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using PagedList;
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
            if (this.User.Identity.IsAuthenticated)
            {
               return Redirect("~/Users/Index");
            }

            var tweets = this.Data.Tweets
                .All()
                .OrderByDescending(x => x.DatePosted)
                .Take(10)
                .Project()
                .To<TweetViewModel>()
                .ToPagedList(page ?? 1, 10); //TODO: remove magic numbers and make them constants

            return View(tweets);
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