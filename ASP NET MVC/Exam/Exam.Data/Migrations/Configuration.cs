namespace Exam.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Exam.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.ContextKey = "Exam.Data.ApplicationDbContext";
            this.AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Teams.Any())
            {
                var teams = this.LoadTeams(context);
                this.LoadMatches(context, teams);
                this.LoadPlayers(context, teams);
                this.LoadComments(context);
                this.LoadUserMatchBets(context);
            }

            base.Seed(context);
        }

        private List<Team> LoadTeams(ApplicationDbContext context)
        {
            var teams = new List<Team>()
            {
                new Team() { Name = "Manchester United F.C.", WebSite = "http://www.manutd.com", DateFounded = new DateTime(1878, 1, 1), NickName = "The Red Devils" },
                new Team() { Name = "Real Madrid", WebSite = "http://www.realmadrid.com", DateFounded = new DateTime(1902, 3, 6), NickName = "The Whites" },
                new Team() { Name = "FC Barcelona", WebSite = "http://www.fcbarcelona.com", DateFounded = new DateTime(1899, 11, 12), NickName = "Barca" },
                new Team() { Name = "Bayern Munich", WebSite = "http://www.fcbayern.de", DateFounded = new DateTime(1900, 2, 13), NickName = "The Bavarians" },
                new Team() { Name = "Manchester City", WebSite = "http://www.mcfc.com", DateFounded = new DateTime(1880, 1, 1), NickName = "The Citizens" },
                new Team() { Name = "Chelsea", WebSite = "https://www.chelseafc.com", DateFounded = new DateTime(1905, 3, 10), NickName = "The Pensioners" },
                new Team() { Name = "Arsenal", WebSite = "http://www.arsenal.com/", DateFounded = new DateTime(1886, 1, 1), NickName = "The Gunners" },
            };

            foreach (var team in teams)
            {
                context.Teams.Add(team);
            }

            context.SaveChanges();

            return teams;
        }

        private void LoadMatches(ApplicationDbContext context, List<Team> teams)
        {
            var matches = new List<Match>()
            {
                new Match() { AwayTeamId = teams[0].Id, HomeTeamId = teams[1].Id, DateTime = new DateTime(2015, 6, 13) },
                new Match() { AwayTeamId = teams[0].Id, HomeTeamId = teams[3].Id, DateTime = new DateTime(2015, 6, 14) },
                new Match() { AwayTeamId = teams[4].Id, HomeTeamId = teams[2].Id, DateTime = new DateTime(2015, 6, 15) },
                new Match() { AwayTeamId = teams[2].Id, HomeTeamId = teams[5].Id, DateTime = new DateTime(2015, 6, 16) },
                new Match() { AwayTeamId = teams[4].Id, HomeTeamId = teams[1].Id, DateTime = new DateTime(2015, 6, 17) },
                new Match() { AwayTeamId = teams[5].Id, HomeTeamId = teams[0].Id, DateTime = new DateTime(2015, 6, 18) },
                new Match() { AwayTeamId = teams[3].Id, HomeTeamId = teams[6].Id, DateTime = new DateTime(2015, 6, 12) },
                new Match() { AwayTeamId = teams[1].Id, HomeTeamId = teams[5].Id, DateTime = new DateTime(2015, 6, 11) },
                new Match() { AwayTeamId = teams[4].Id, HomeTeamId = teams[5].Id, DateTime = new DateTime(2015, 6, 10) },
                new Match() { AwayTeamId = teams[6].Id, HomeTeamId = teams[5].Id, DateTime = new DateTime(2015, 6, 19) },
                new Match() { AwayTeamId = teams[2].Id, HomeTeamId = teams[6].Id, DateTime = new DateTime(2015, 6, 20) },
            };

            foreach (var match in matches)
            {
                context.Matches.Add(match);
                context.SaveChanges();
            }
        }

        private void LoadPlayers(ApplicationDbContext context, List<Team> teams)
        {
            var players = new List<Player>()
            {
                new Player() { Name = "Alexis Sanchez", TeamId = teams[2].Id, DateofBirth = new DateTime(1982, 1, 3), Height = 1.65 },
                new Player() { Name = "Arjen Robben", TeamId = teams[1].Id, DateofBirth = new DateTime(1982, 1, 3), Height = 1.65 },
                new Player() { Name = "Franck Ribery", TeamId = teams[0].Id, DateofBirth = new DateTime(1982, 1, 3), Height = 1.65 },
                new Player() { Name = "Wayne Rooney", TeamId = teams[0].Id, DateofBirth = new DateTime(1982, 1, 3), Height = 1.65 },
                new Player() { Name = "Lionel Messi", DateofBirth = new DateTime(1982, 1, 13), Height = 1.65 },
                new Player() { Name = "Theo Walcott", DateofBirth = new DateTime(1983, 2, 17), Height = 1.75 },
                new Player() { Name = "Cristiano Ronaldo", DateofBirth = new DateTime(1984, 3, 16), Height = 1.85 },
                new Player() { Name = "Aaron Lennon", DateofBirth = new DateTime(1985, 4, 15), Height = 1.95 },
                new Player() { Name = "Gareth Bale", DateofBirth = new DateTime(1986, 5, 14), Height = 1.90 },
                new Player() { Name = "Antonio Valencia", DateofBirth = new DateTime(1987, 5, 23), Height = 1.82 },
                new Player() { Name = "Robin van Persie", DateofBirth = new DateTime(1988, 6, 13), Height = 1.84 },
                new Player() { Name = "Ronaldinho", DateofBirth = new DateTime(1989, 7, 30), Height = 1.87 },
            };

            foreach (var player in players)
            {
                context.Players.Add(player);
            }

            context.SaveChanges();
        }

        private void LoadComments(ApplicationDbContext context)
        {
        }

        private void LoadUserMatchBets(ApplicationDbContext context)
        {
        }
    }
}
