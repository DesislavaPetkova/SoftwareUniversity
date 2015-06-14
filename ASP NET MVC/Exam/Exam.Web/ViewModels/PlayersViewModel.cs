namespace Exam.Web.ViewModels
{
    using Exam.Common.Mappings;
    using Exam.Models;

    public class PlayersViewModel : IMapFrom<Player>
    {
        public int Id { get; set; }
     
        public string Name { get; set; }

        public string DateofBirth { get; set; }
        
        public double Height { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}