namespace Bookmarks.Data
{
    using System.Data.Entity;

    using Bookmarks.Models;

    public interface IBookmarsDbContext
    {
        IDbSet<Comment> Comments { get; set; }

        IDbSet<Vote> Votes { get; set; }

        IDbSet<Bookmark> Bookmarks { get; set; }

        IDbSet<Category> Categories { get; set; }

        int SaveChanges();
    }
}
