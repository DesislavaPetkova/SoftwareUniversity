using System.Collections.Generic;
using System.Security.Policy;
using System.Web.Security;
using Loyalty.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Loyalty.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Loyalty.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Loyalty.Data.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Shops.Any())
            {
                this.LoadShops(context);
            }
            

        }

        private List<Shop> LoadShops(ApplicationDbContext context)
        {
            var newShops = new List<Shop>()
            {
                new Shop(){Name = "Пикадили Младост", Adress = "ул. Бели Брези 13", TargetAmount = 1000, DiscountType = DiscountType.Amount, Discount = 2},
                new Shop(){Name = "Пикадили Център 24", Adress = "ул. Пирин 1А", TargetAmount = 500, DiscountType = DiscountType.Percentage, Discount = 3},
                new Shop(){Name = "Пикадили Почивка", Adress = "бул. Княз Борис 182", TargetAmount = 1500, DiscountType = DiscountType.Amount, Discount = 2.5M},
                new Shop(){Name = "Пикадили Дейли", Adress = "ул. Цар Освободител 68", TargetAmount = 700, DiscountType = DiscountType.Percentage, Discount = 2},
                new Shop(){Name = "Ориндж 24", Adress = "бул. Хан Аспарух 213", TargetAmount = 650, DiscountType = DiscountType.Percentage, Discount = 2}
            };

            foreach (var shop in newShops)
            {
                context.Shops.Add(shop);
            }
            context.SaveChanges();

            return newShops;
        }

    }
}
