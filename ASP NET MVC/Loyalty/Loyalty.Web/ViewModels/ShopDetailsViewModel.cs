﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam.Common.Mappings;
using Loyalty.Models;

namespace Loyalty.Web.ViewModels
{
    public class ShopDetailsViewModel : IMapFrom<Shop>
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public string Adress { get; set; }
        
        public decimal TargetAmount { get; set; }

        public DiscountType DiscountType { get; set; }
        
        public decimal Discount { get; set; }
    }
}