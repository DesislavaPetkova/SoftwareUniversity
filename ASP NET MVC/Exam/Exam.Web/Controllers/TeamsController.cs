namespace Exam.Web.Controllers
{
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using Exam.Data;
    using Exam.Models;
    using Exam.Web.ViewModels;

    public class TeamsController : BaseController
    {
        
        public TeamsController(IExamData data)
            : base(data)
        {
        }

        
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Details(int id)
        {
            var team = this.Data.Teams.All()
                .Include(x =>x.Votes)
                .FirstOrDefault(x => x.Id == id);
            var teamViewModel = Mapper.Map<TeamDetailsViewModel>(team);
            teamViewModel.UserHasVoted = team.Votes.Any(x => x.UserId == this.UserProfile.Id);
            return this.View(teamViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Vote(int teamId)
        {
            var team = this.Data.Teams.All().FirstOrDefault(x => x.Id == teamId);
            if (team != null)
            {
                var hasVoted = team.Votes.Any(x => x.UserId == this.UserProfile.Id);
                if (!hasVoted)
                {
                    this.Data.Votes.Add(new Vote
                        {
                            TeamId  = team.Id,
                            UserId = this.UserProfile.Id,
                            Value = 1
                        });
                    this.Data.SaveChanges();
                }

                var votesCount = team.Votes.Sum(x => x.Value);
                return this.Content(votesCount.ToString());
            }
            return new EmptyResult();
        }
    }
}