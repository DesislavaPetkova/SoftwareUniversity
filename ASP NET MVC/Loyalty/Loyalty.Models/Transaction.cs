using System;
using System.ComponentModel.DataAnnotations;

namespace Loyalty.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public decimal Amount { get; set; }

        public decimal SavedAmount { get; set; }
        [Required]
        public string ReceiptNumber { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
