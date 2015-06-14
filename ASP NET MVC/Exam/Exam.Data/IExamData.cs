namespace Exam.Data
{
    using Exam.Data.Repositories;
    using Exam.Models;

    public interface IExamData
    {
        IRepository<User> Users { get; }
        IRepository<Match> Matches { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Vote> Votes { get; }
        IRepository<Bet> Bets { get; }
        IRepository<Player> Players { get; }
        IRepository<Team> Teams { get; }

            

        int SaveChanges();
    }
}
