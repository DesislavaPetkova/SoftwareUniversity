using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Loyalty.Data;
using Loyalty.Models;
using Microsoft.AspNet.Identity;

namespace Loyalty.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected BaseController(IApplicationData data)
        {
            this.Data = data;
        }

        protected BaseController(IApplicationData data, User userProfile)
            : this(data)
        {
            this.UserProfile = userProfile;
        }

        public IApplicationData Data { get; private set; }

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