using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam.Common.Mappings;
using Loyalty.Models;

namespace Loyalty.Web.ViewModels
{
    public class TransactionViewModel : IMapFrom<Transaction>
    {
        public int Id { get; set; }
       
        public DateTime DateTime { get; set; }
        
        public decimal Amount { get; set; }
        public decimal SavedAmount { get; set; }
      
        public string ReceiptNumber { get; set; }
        
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}