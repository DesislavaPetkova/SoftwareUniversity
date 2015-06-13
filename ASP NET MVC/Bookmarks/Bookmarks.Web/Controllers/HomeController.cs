using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookmarks.Web.Controllers
{
    using AutoMapper.QueryableExtensions;

    using Bookmarks.Common;
    using Bookmarks.Data;
    using Bookmarks.Web.ViewModels;

    public class HomeController : BaseController
    {

        public HomeController(IBookmarksData data) : base(data)
        {
            
        }
        public ActionResult Index()
        {
            var bookmarks = this.Data.Bookmarks
                .All()
                .OrderByDescending(x => x.Votes.Count)
                .ThenBy(x => x.Title)
                .Take(GlobalConstants.HomePageNumbersofBookmarks)
                .Project()
                .To<BookmarkViewModel>();
            return View(bookmarks);
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