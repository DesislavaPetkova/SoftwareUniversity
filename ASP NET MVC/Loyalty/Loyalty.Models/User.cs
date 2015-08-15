using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Loyalty.Models
{
    public class User : IdentityUser
    {
        private ICollection<Transaction> transactions;

        public User()
        {
            this.Transactions = new HashSet<Transaction>();
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }

        public decimal TurnoverAmount { get; set; }
        public decimal DiscountAmount { get; set; }

    }
}
