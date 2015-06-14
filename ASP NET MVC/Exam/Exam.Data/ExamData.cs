namespace Exam.Data
{
    using System;
    using System.Collections.Generic;

    using Exam.Data.Repositories;
    using Exam.Models;

    public class ExamData : IExamData
    {
        private IApplicationDbContext context;

        private IDictionary<Type, Object> repositories;

        public ExamData(IApplicationDbContext context)
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
        public IRepository<Bet> Bets
        {
            get
            {
                return this.GetRepository<Bet>();
            }
        }
        public IRepository<Player> Players
        {
            get
            {
                return this.GetRepository<Player>();
            }
        }
        public IRepository<Comment> Comments
        {
            get
            {
                return this.GetRepository<Comment>();
            }
        }

        public IRepository<Vote> Votes
        {
            get
            {
                return this.GetRepository<Vote>();
            }
        }

        public IRepository<Team> Teams
        {
            get
            {
                return this.GetRepository<Team>();
            }
        }

        public IRepository<Match> Matches
        {
            get
            {
                return this.GetRepository<Match>();
            }
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
