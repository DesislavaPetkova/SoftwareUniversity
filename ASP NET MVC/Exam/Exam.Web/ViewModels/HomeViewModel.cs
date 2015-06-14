namespace Exam.Web.ViewModels
{
    using System.Collections.Generic;

    public class HomeViewModel
    {

        public IEnumerable<TeamViewModel> TeamViewModel { get; set; }
        public IEnumerable<MatchViewModel> MatchViewModel { get; set; }  


    }
}