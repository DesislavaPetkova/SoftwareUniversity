using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Exam.Common.Mappings;
using Loyalty.Models;

namespace Loyalty.Web.ViewModels
{
    public class CustomerViewModel : IMapFrom<User>
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; }

        public decimal TurnoverAmount { get; set; }
        public decimal DiscountAmount { get; set; }

        
    }
}