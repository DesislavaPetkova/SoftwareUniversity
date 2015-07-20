using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNet.Identity;
using PagedList;
using Twitter.Data;
using Twitter.Web.ViewModels;

namespace Twitter.Web.Controllers
{
    public class UsersController : BaseController
    {
        public UsersController(ITwitterData data) 
            : base(data)
        {
            
        }

        [Authorize]
        public ActionResult Index(int? page)
        {
           

            return View();
        }
    }
}