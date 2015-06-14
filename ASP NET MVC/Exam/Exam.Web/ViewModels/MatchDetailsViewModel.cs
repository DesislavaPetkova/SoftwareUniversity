namespace Exam.Web.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Exam.Common.Mappings;
    using Exam.Models;

    public class MatchDetailsViewModel : IMapFrom<Match>

    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public string DateTime { get; set; }

        public virtual IEnumerable<CommentsViewModel> Comments { get; set; }

        //public virtual ICollection<BetViewModel> Bets { get; set; } TODO: 

    }
}