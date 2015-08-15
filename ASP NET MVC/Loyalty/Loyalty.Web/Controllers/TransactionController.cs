using System;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Loyalty.Common;
using Loyalty.Data;
using Loyalty.Models;
using Loyalty.Web.InputModels;
using Loyalty.Web.ViewModels;
using Microsoft.AspNet.Identity;
using PagedList;

namespace Loyalty.Web.Controllers
{
    public class TransactionController : BaseController
    {
        public TransactionController(IApplicationData data)
            :base(data)
        {
            
        }
        // GET: Transaction
        public ActionResult Index(int? page)
        {
            var transactions = this.Data.Transactions.All()
                .Where(x => x.UserId == this.UserProfile.Id)
                .OrderByDescending(x => x.DateTime)
                .Project()
                .To<TransactionViewModel>();
               
            return View(transactions.ToPagedList(page ?? GlobalConstants.DefaultTransNumber, GlobalConstants.DefaultTransSize));
        }

        
        // GET: Transaction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionInputModel model)
        {
            var rnd = new Random();
            var shopslast = this.Data.Shops.All().ToArray();
            var rndNumber = rnd.Next(shopslast[0].Id, shopslast.Last().Id);
            
            

            
                if (model != null && this.ModelState.IsValid)
                {
                    var trans = Mapper.Map<Transaction>(model);
                    trans.DateTime = DateTime.Now;
                    trans.UserId = this.User.Identity.GetUserId();
                    trans.ShopId = rndNumber;

                    var shop = this.Data.Shops.All()
                        .FirstOrDefault(x=>x.Id == trans.ShopId);

                    if (shop != null && (shop.DiscountType == DiscountType.Percentage && trans.Amount >= shop.TargetAmount))
                    {
                        trans.SavedAmount = trans.Amount * shop.Discount/100;
                    }

                    if (shop != null && (shop.DiscountType == DiscountType.Amount && trans.Amount >= shop.TargetAmount))
                    {
                        var save = trans.Amount - shop.Discount;
                        trans.SavedAmount = trans.Amount - save;
                    }

                    this.Data.Transactions.Add(trans);


                    this.Data.SaveChanges();
                }

                return RedirectToAction("Index", "Customer");
        }

      
      
    }
}
