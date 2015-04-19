namespace BugTracker.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }

        public virtual User Author { get; set; }

        public string AuthorId { get; set; }

        public DateTime Date { get; set; }
        
        public virtual Bug Bug { get; set; }
        [Required]
        public int BugId { get; set; }
    }
}
