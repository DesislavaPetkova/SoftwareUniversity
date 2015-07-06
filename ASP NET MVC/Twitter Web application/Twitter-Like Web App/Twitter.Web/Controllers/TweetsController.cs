using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twitter.Data;

namespace Twitter.Web.Controllers
{
    public class TweetsController : BaseController
    {
        public TweetsController(ITwitterData data) :base(data)
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}