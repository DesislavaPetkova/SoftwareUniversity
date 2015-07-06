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
            var userId = this.User.Identity.GetUserId();
            var followedUsers = this.Data.Users.All();
                //.Where(x => x.Id == (this.Data.UsersToFollowings.All().FirstOrDefault()))
            

//            var tweets = this.Data.Tweets
//                .All()
//                .Where(x => x.Id =)
//                .Take(10)
//                .OrderByDescending(x => x.DatePosted)
//                .Project()
//                .To<TweetViewModel>()
//                .ToPagedList(page ?? 1, 10);


            return View();
        }
    }
}