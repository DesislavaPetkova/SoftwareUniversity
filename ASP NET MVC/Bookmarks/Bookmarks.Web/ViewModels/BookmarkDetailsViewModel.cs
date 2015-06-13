namespace Bookmarks.Web.ViewModels
{
    using System.Collections.Generic;

    using Bookmarks.Common.Mappings;
    using Bookmarks.Models;

    public class BookmarkDetailsViewModel : IMapFrom<Bookmark>
    {
        public int Id { get; set; }

        
        public string Title { get; set; }
        
        public string Url { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual IEnumerable<Vote> Votes { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }
    }
}