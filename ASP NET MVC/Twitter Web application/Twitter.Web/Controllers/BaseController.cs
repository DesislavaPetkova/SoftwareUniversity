using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Twitter.Data.Controllers
{
    using System.Web.Routing;

    using Microsoft.AspNet.Identity;

    using Twitter.Data;

    public class BaseController : Controller
    {
        private TwitterDbContext db = new TwitterDbContext();
        
        private User userProfile;

        public BaseController()
        {
            this.UserProfile = this.userProfile;
            this.Db = this.db;
        }


        public TwitterDbContext Db
        {
            get
            {
                return this.db;
            }
            set
            {
                this.db = value;
            }
        }

        public User UserProfile
        {
            get
            {
                return this.userProfile;
            }
            set
            {
                this.userProfile = value;
            }
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.GetUserName();
                var user = this.Db.Users.FirstOrDefault(x => x.UserName == username);
                this.UserProfile = user;
            }
            
            return base.BeginExecute(requestContext, callback, state);
        }
    }
}