using System.Data.Entity;
using Loyalty.Data.Migrations;
using Loyalty.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Loyalty.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Shop> Shops { get; set; }
        public IDbSet<Transaction> Transactions { get; set; }

        
    }
}
