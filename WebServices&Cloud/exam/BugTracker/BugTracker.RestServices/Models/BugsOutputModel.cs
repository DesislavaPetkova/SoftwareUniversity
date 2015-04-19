namespace BugTracker.RestServices.Models
{
    using System;

    using BugTracker.Data.Models;

    public class BugsOutputModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Status { get; set; }

        public string Author { get; set; }

        public DateTime DateCreated { get; set; }

        public string Description { get; set; }
//
        public Object Comments { get; set; }
    }
}
