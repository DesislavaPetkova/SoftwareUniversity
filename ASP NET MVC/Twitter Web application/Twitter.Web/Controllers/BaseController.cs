﻿namespace Twitter.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Microsoft.AspNet.Identity;

    using Twitter.Data;
    using Twitter.Models;


    public class BaseController : Controller
    {
        private TwitterDbContext db = new TwitterDbContext();
        
        private User userProfile;

        public BaseController()
        {
            this.UserProfile = this.userProfile;
            this.Db = this.db;
        }

        protected TwitterDbContext Db
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