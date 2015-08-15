using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Loyalty.Common;
using Loyalty.Data;
using Loyalty.Models;
using Loyalty.Web.InputModels;
using Loyalty.Web.ViewModels;
using PagedList;

namespace Loyalty.Web.Controllers
{
    public class ShopController : BaseController
    {

        public ShopController(IApplicationData data)
            :base(data)
        {
            
        }

        // GET: Shop
        public ActionResult Index(int? page)
        {

           var shops = this.Data.Shops.All()
                .OrderBy(x =>x.Name)
//                .Take(GlobalConstants.DefaultPageSize)
                .Project()
                .To<ShopViewModel>();

            return View(shops.ToPagedList(page ?? GlobalConstants.DefaultPageNumber, GlobalConstants.DefaultPageSize));
        }

        public ActionResult Details(int? id)
        {
            var shop = this.Data.Shops.All()
                .Where(x => x.Id == id)
                .Project()
                .To<ShopDetailsViewModel>()
                .FirstOrDefault();

            if (shop == null)
            {
                return HttpNotFound();
            }

            return this.View(shop);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var shop = this.Data.Shops
                .All().FirstOrDefault(x => x.Id == id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Shop shop)
        {
            if (ModelState.IsValid)
            {
                this.Data.Shops.Update(shop);
                this.Data.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(shop);

        }

        public ActionResult Create()
        {

            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopInputModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                var shop = Mapper.Map<Shop>(model);

                this.Data.Shops.Add(shop);
                this.Data.SaveChanges();
            }
            return RedirectToAction("Index", "Shop");
        }

    }
}