using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Twitter.Data;
using Twitter.Models;
using Twitter.Web.InputModels;
using Twitter.Web.ViewModels;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InputTweetModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                model.UserId = this.UserProfile.Id;
                var tweet = Mapper.Map<Tweet>(model);
                tweet.DatePosted = DateTime.Now;
                this.Data.Tweets.Add(tweet);
                this.Data.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}