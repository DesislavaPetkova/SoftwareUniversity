using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Loyalty.Models
{
    public class Shop
    {
        private ICollection<Transaction> transactions;

        public Shop()
        {
           this.Transactions = new HashSet<Transaction>(); 
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public decimal TargetAmount { get; set; }

        public DiscountType DiscountType { get; set; }
        [Required]
        public decimal Discount { get; set; }

        public virtual ICollection<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }
    }
}
