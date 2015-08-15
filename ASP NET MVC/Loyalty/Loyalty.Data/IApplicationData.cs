using Loyalty.Data.Repositories;
using Loyalty.Models;

namespace Loyalty.Data
{
    public interface IApplicationData
    {
        IRepository<User> Users { get; }

        IRepository<Shop> Shops { get; }

        IRepository<Transaction> Transactions { get; } 

        int SaveChanges();
    }
}
