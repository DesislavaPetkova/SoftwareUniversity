namespace Exam.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using Exam.Data;
    using Exam.Web.ViewModels;

    public class HomeController : BaseController
    {
        public HomeController(IExamData data)
            : base(data)
        {
        }
        public ActionResult Index()
        {
            
//            var vm = new HomeViewModel();
//            vm.AllTeams = this.Data.Teams.All().ToList();
//            vm.AllMatches = this.Data.Matches.All().ToList();
            var matches = this.Data.Matches
                .All().OrderByDescending(x => x.Bets.Count)
                .Take(3)
                .Project()
                .To<MatchViewModel>();

            var teams = this.Data.Teams
                .All()
                .OrderByDescending(x => x.Votes.Count)
                .Take(3).Project()
                .To<TeamViewModel>();

            var homeModel = new HomeViewModel { MatchViewModel = matches, TeamViewModel = teams };

            return this.View(homeModel);
        }

       

        
    }
}