namespace Twitter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tweet
    {
        private ICollection<User> favoriteByUsers;
        private ICollection<Report> reports; 

        public Tweet()
        {
            this.FavoriteByUsers = new HashSet<User>();
            this.Reports = new HashSet<Report>();
        }
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }

        public DateTime DatePosted { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
        
        [Url]
        public string URL { get; set; }

        public virtual ICollection<User> FavoriteByUsers
        {
            get { return this.favoriteByUsers; }
            set { this.favoriteByUsers = value; }
        }

        public virtual ICollection<Report> Reports
        {
            get { return this.reports; }
            set { this.reports = value; }
        }

    }
}
