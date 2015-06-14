namespace Exam.Data
{
    using System.Data.Entity;

    using Exam.Models;

    public interface IApplicationDbContext
    {
        IDbSet<Comment> Comments { get; set; }

        IDbSet<Vote> Votes { get; set; }

        IDbSet<Team> Teams { get; set; }
        IDbSet<Match> Matches { get; set; }

        IDbSet<Bet> Bets { get; set; }
        IDbSet<Player> Players { get; set; }

        int SaveChanges();
    }
}
    