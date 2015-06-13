namespace Bookmarks.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using Bookmarks.Common;
    using Bookmarks.Data;
    using Bookmarks.Models;
    using Bookmarks.Web.InputModels;
    using Bookmarks.Web.ViewModels;
    using System.Web.Mvc.Expressions;
    using PagedList;
    [Authorize]
    public class BookmarksController : BaseController
    {
        public BookmarksController(IBookmarksData data)
            : base(data)
        {
        }

        [AllowAnonymous]
        public ActionResult Index(int? page)
        {
            var bookmarks = this.Data.Bookmarks
                .All()
                .OrderBy(x => x.Title)
                .Project()
                .To<BookmarkViewModel>()
                .ToPagedList(page ?? GlobalConstants.DefaultStartPage, GlobalConstants.DefaultPageSize);
            return this.View(bookmarks);
        }
        
        public ActionResult Details(int id)
        {
            var bookmark = this.Data.Bookmarks.All()
                .Where(x => x.Id == id)
                .Project()
                .To<BookmarkDetailsViewModel>()
                .FirstOrDefault();
            return this.View(bookmark);
        }

        public ActionResult Create()
        {
            this.LoadCategories();
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookmarkInputModel model)
        {

            if (model != null && this.ModelState.IsValid)
            {
                var bookmark = Mapper.Map<Bookmark>(model);
                this.Data.Bookmarks.Add(bookmark);
                this.Data.SaveChanges();

                return this.RedirectToAction(x => x.Details(bookmark.Id));
            }
            this.LoadCategories();
            return this.View(model);
        }

        private void LoadCategories()
        {
            this.ViewBag.Categories =
                this.Data.Categories
                .All()
                .Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name, });
        }
        
    }
}