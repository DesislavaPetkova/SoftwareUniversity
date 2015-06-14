namespace Exam.Web.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    using AutoMapper;

    using Exam.Common.Mappings;
    using Exam.Models;

    using Microsoft.AspNet.Identity;

    public class TeamDetailsViewModel : IMapFrom<Team>, IHaveCustomMappings
    {
       
        public int Id { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public string WebSite { get; set; }

        public string DateFounded { get; set; }

        public virtual IEnumerable<PlayersViewModel> Players { get; set; }

        public virtual int Votes { get; set; }

        public bool UserHasVoted { get; set; }

        //        public void CreateMappings(AutoMapper.IConfiguration configuration)
//        {
//            configuration.CreateMap<Team, TeamDetailsViewModel>()
//                .ForMember(x => x., cnf => cnf.MapFrom(x => x.Votes.Sum(v => v.Value)));
//        }

        public void CreateMappings(IConfiguration configuration)
        {
            var userId = Thread.CurrentPrincipal.Identity.GetUserId();
            configuration.CreateMap<Team, TeamDetailsViewModel>()
                .ForMember(x => x.Votes, cnf => cnf.MapFrom(m => m.Votes.Any() ? m.Votes.Sum(x => x.Value) : 0));
        }
    }
}