namespace Exam.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Exam.Data;
    using Exam.Models;

    using Microsoft.AspNet.Identity;

    public abstract class BaseController : Controller
    {

        protected BaseController(IExamData data)
        {
            this.Data = data;
        }

        protected BaseController(IExamData data, User userProfile)
            : this(data)
        {
            this.UserProfile = userProfile;
        }

        protected IExamData Data { get; private set; }

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

//            if (!requestContext.HttpContext.Request.IsAjaxRequest())
//            {
//                // This should be after base.BeginExecute so we can access TempData
//                var systemMessages = this.PrepareSystemMessages();
//                this.ViewBag.SystemMessages = systemMessages;
//            }

            return result;
        }
    } 
}