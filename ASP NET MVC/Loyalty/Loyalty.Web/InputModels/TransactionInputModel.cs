using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam.Common.Mappings;
using Loyalty.Models;

namespace Loyalty.Web.InputModels
{
    public class TransactionInputModel : IMapTo<Transaction>
    {

        public int Id { get; set; } 
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }
        public string ReceiptNumber { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}