namespace BugTracker.RestServices.Models
{
    using System.ComponentModel.DataAnnotations;

    using BugTracker.Data.Models;

    public class BugInputModel
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public StatusTypes Status { get; set; }
    }
}
