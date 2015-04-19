namespace BugTracker.RestServices.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BugTracker.Data.Models;

    public class CommentInputModel
    {
        public int Id { get; set; }

        public string AuthorId { get; set; }
        [Required]
        public int BugId { get; set; }
        
        public DateTime Date { get; set; }
        [Required]
        [MinLength(1)]
        public string Text { get; set; }

      
    }
}
