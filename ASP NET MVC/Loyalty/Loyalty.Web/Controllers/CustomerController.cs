using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using Loyalty.Data;
using Loyalty.Web.ViewModels;

namespace Loyalty.Web.Controllers
{
    public class CustomerController : BaseController
    {
        public CustomerController(IApplicationData data)
            :base(data)
        {
            
        }

        [Authorize]
        public ActionResult Index()
        {
            var customer = this.Data.Users.All()
                .Where(x => x.Id == this.UserProfile.Id)
                .Project()
                .To<CustomerViewModel>()
                .FirstOrDefault();

//            customer.TurnoverAmount = this.Data.Transactions.All()
//                .Where(x =>x.UserId == this.UserProfile.Id)
//                .Sum(x=>x.Amount);

            var trans = this.Data.Transactions.All()
                .Where(x => x.UserId == this.UserProfile.Id)
                .GroupBy(g => g.Shop.Name)
                .Select(s => new
                {
                    Name = s.Key,
                    sum = s.Sum(g => g.Amount)
                    
                })
                .ToDictionary(k => k.Name, i=>i.sum);

//            var discounts = this.Data.Transactions.All()
//                .Where(x => x.UserId == this.UserProfile.Id)
//                .GroupBy(g => g.Shop.Name)  
//                .Select(s => new
//                {
//                    Name = s.Key,
//                    sum = s.Sum(g => g.SavedAmount)
//                    
//                })
//                .ToDictionary(k => k.Name, i => i.sum);
            var discounts = this.Data.Transactions
                .All().Any(x => x.UserId == this.UserProfile.Id);

            decimal discountsSum = 0;
            if (discounts)
            {
                discountsSum = this.Data.Transactions.All()
                    .Where(x => x.UserId == this.UserProfile.Id)
                    .Sum(s => s.SavedAmount);
            }
                

            ViewBag.transactions = trans;
            ViewBag.saved = discountsSum;
            return this.View(customer);
        }
        
    }
}
