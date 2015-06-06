namespace Twitter.Data.Repositories
{
    using System.Data.Entity;
    using System.Linq;

    using Twitter.Data;
    using Twitter.Web.Repositories;

    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private TwitterDbContext dbContext;

        private IDbSet<TEntity> entitySet;

        public IDbSet<TEntity> EntitySet
        {
            get
            {
                return this.entitySet;
            }
        }

        public TwitterDbContext DbContext
        {
            get
            {
                return this.dbContext;
            }
        }

        public IQueryable<TEntity> All()
        {
            return this.entitySet;
        }

        public TEntity Find(object id)
        {
            return this.entitySet.Find(id);
        }

        public void Add(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Added); 
        }

        public void Update(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Modified); 
        }

        public void Remove(TEntity entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public TEntity Remove(object id)
        {
            var entity = this.Find(id);
            this.Remove(entity);
            return entity;
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        private void ChangeState(TEntity entity, EntityState state)
        {
            var entry = this.dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.entitySet.Attach(entity);
            }

            entry.State = state;
        }
    }
}
