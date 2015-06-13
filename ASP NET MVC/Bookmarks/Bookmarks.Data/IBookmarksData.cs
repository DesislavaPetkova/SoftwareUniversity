using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarks.Data
{
    using Bookmarks.Data.Repositories;
    using Bookmarks.Models;

    public interface IBookmarksData
    {
        IRepository<User> Users { get; }
        IRepository<Category> Categories { get; }
        IRepository<Bookmark> Bookmarks { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Vote> Votes { get; }


        int SaveChanges();
    }
}
