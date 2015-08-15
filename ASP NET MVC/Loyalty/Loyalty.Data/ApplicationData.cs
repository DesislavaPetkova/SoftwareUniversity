using System;
using System.Collections.Generic;
using Loyalty.Data.Repositories;
using Loyalty.Models;
using Loyalty.Data;

namespace Loyalty.Data
{
    public class ApplicationData : IApplicationData
    {
        private IApplicationDbContext context;

        private IDictionary<Type, Object> repositories;

        public ApplicationData(IApplicationDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }

        public IRepository<Transaction> Transactions
        {
            get { return this.GetRepository<Transaction>(); }
        }

        public IRepository<Shop> Shops
        {
            get { return this.GetRepository<Shop>(); }
        }


        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                var typeOfRepository = typeof(GenericRepository<T>);
                var repository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(type, repository);
            }
            return (IRepository<T>)this.repositories[type];
        }
    }
}
