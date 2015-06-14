namespace Exam.Web.ViewModels
{
    using Exam.Common.Mappings;
    using Exam.Models;

    public class TeamViewModel : IMapFrom<Team>
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public string NickName { get; set; }
        
        public string WebSite { get; set; }

        public string DateFounded { get; set; }

    }
}