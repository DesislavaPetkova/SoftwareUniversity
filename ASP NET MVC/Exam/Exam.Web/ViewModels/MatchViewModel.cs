namespace Exam.Web.ViewModels
{
    using Exam.Common.Mappings;
    using Exam.Models;

    public class MatchViewModel : IMapFrom<Match>
    {
        public int Id { get; set; }
       
        public int HomeTeamId { get; set; }
        
        public int AwayTeamId { get; set; }

        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        
        public string DateTime { get; set; }

    }
}