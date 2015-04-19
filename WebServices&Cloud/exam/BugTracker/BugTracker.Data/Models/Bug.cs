namespace BugTracker.Data.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Bug
    {
        public Bug()
        {
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        [Required]
        public StatusTypes Status { get; set; }

        public virtual User Author { get; set; }

        public string AuthorId { get; set; }
        [Required]
        public DateTime SubmitedDate { get; set; }
        [Required]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
