namespace BugTracker.RestServices.Models
{
    using System;

    public class CommentOutputModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime DateCreated { get; set; }

        public string BugId { get; set; }

        public string BugTitle { get; set; }

        public string Text { get; set; }
    }
}
