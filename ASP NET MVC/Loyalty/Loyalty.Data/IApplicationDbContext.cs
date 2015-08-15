using System.Data.Entity;
using Loyalty.Models;

namespace Loyalty.Data
{
    public interface IApplicationDbContext
    {
        IDbSet<Shop> Shops { get; set; }

        IDbSet<Transaction> Transactions { get; set; }
        

        int SaveChanges();
    }
}
    