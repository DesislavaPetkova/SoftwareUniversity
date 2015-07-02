using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.Identity;
using Twitter.Data;
using Twitter.Models;

namespace Twitter.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected BaseController(ITwitterData data)
        {
            this.Data = data;
        }

        public BaseController(ITwitterData data, User userProfile)
            : this(data)
        {
            this.UserProfile = userProfile;
        }
        protected ITwitterData Data { get; private set; }

        protected User UserProfile { get; private set; }


        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.GetUserName();
                this.UserProfile = this.Data.Users
                    .All()
                    .FirstOrDefault(x => x.UserName == username);
            }

            var result = base.BeginExecute(requestContext, callback, state);
            return result;
        }
    }
}