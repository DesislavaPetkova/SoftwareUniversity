namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    using Exam.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.ContextKey = "Exam.Data.ApplicationDbContext";
            this.AutomaticMigrationDataLossAllowed = false;
            
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate(new Team
                {
                    Name = "Manchester United F.C.",
                    NickName = "The Red Devils",
                    WebSite = "http://www.manutd.com",
                    DateFounded = "1-Jun-1878"
                });
            context.Teams.AddOrUpdate(new Team
            {
                Name = "Real Madrid",
                NickName = "The Whites",
                WebSite = "http://www.realmadrid.com",
                DateFounded = "6-Mar-1902"
            });
            context.Teams.AddOrUpdate(new Team
            {
                Name = "Bayern Munich",
                NickName = "The Bavarians",
                WebSite = "http://www.fcbayern.de",
                DateFounded = "13-Feb-1900"
            });
            context.Teams.AddOrUpdate(new Team
            {
                Name = "FC Barcelona",
                NickName = "Barca",
                WebSite = "http://www.fcbarcelona.com",
                DateFounded = "12-Nov-1899"
            });
            context.Teams.AddOrUpdate(new Team
            {
                Name = "Manchester City",
                NickName = "The Citizens",
                WebSite = "http://www.mcfc.com",
                DateFounded = "1-May-1880"
            });

            context.Matches.AddOrUpdate(new Match()
            {
                HomeTeamId = 1,
                AwayTeamId = 2,
                DateTime = "2015-Jun-13"
            });
            context.Matches.AddOrUpdate(new Match()
            {
                HomeTeamId = 3,
                AwayTeamId = 1,
                DateTime = "2015-Jun-13"
            });
            context.Matches.AddOrUpdate(new Match()
            {
                HomeTeamId = 2,
                AwayTeamId = 3,
                DateTime = "2015-Jun-13"
            });
            context.Matches.AddOrUpdate(new Match()
            {
                HomeTeamId = 4,
                AwayTeamId = 1,
                DateTime = "2015-Jun-13"
            });

            context.Players.AddOrUpdate(new Player
            {
                Name = "Alexis Sanchez",
                DateofBirth = "1982-01-03",
                Height = 1.65,
                TeamId = 4
            });
            context.Players.AddOrUpdate(new Player
            {
                Name = "Arjen Robben",
                DateofBirth = "1982-01-03",
                Height = 1.65,
                TeamId = 2
            });
            context.Players.AddOrUpdate(new Player
            {
                Name = "Franck Ribery",
                DateofBirth = "1982-01-03",
                Height = 1.75,
                TeamId = 2
            });
            context.Players.AddOrUpdate(new Player
            {
                Name = "Wayne Rooney",
                DateofBirth = "1982-01-03",
                Height = 1.75,
                TeamId = 1
            });

            context.Players.AddOrUpdate(new Player
            {
                Name = "Lionel Messi",
                DateofBirth = "1982-01-03",
                Height = 1.75,
                
            });
            context.Players.AddOrUpdate(new Player
            {
                Name = "Theo Walcott",
                DateofBirth = "1982-01-03",
                Height = 1.75,
                
            });
            context.Players.AddOrUpdate(new Player
            {
                Name = "Cristiano Ronaldo",
                DateofBirth = "1982-01-03",
                Height = 1.75,
                
            });
            context.Players.AddOrUpdate(new Player
            {
                Name = "Aaron Lennon",
                DateofBirth = "1982-01-03",
                Height = 1.75,
                
            });

            context.Comments.AddOrUpdate(new Comment
            {
                MatchId = 1,
                Content = "The best match this summer!",
                UserId = "ce8d003a-1ee1-4565-ad71-264558158e45",
                DataTime = DateTime.Now
            });

            context.Bets.AddOrUpdate(new Bet
            {
                MatchId = 1,
                HomeBet = 30,
                AwayBet = 0,
                UserId = "ce8d003a-1ee1-4565-ad71-264558158e45"

            });

            context.Votes.AddOrUpdate(new Vote
            {
                TeamId = 2,
                UserId = "ce8d003a-1ee1-4565-ad71-264558158e45"

            });
        }
    }
}
