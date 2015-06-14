namespace Exam.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using Exam.Common;
    using Exam.Data;
    using Exam.Models;
    using Exam.Web.InputModels;
    using Exam.Web.ViewModels;

    using Microsoft.AspNet.Identity;

    using PagedList;

    public class MatchesController : BaseController
    {
        
        

        public MatchesController(IExamData data)
            : base(data)
        {
        }

        [AllowAnonymous]
        public ActionResult Index(int? page)
        {
            var matches =
                this.Data.Matches.All()
                    .OrderBy(m => m.DateTime)
                    .Project()
                    .To<MatchViewModel>()
                    .ToPagedList(page ?? GlobalConstants.DefaultStartPage, GlobalConstants.DefaultPageSize);
            return this.View(matches);
        }

        public ActionResult Details(int id)
        {
            var match = this.Data.Matches.All()
               .Where(x => x.Id == id)
               .Project()
               .To<MatchDetailsViewModel>()
               .FirstOrDefault();
            return this.View(match);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult AddComment(CommentInputModel model)
        {
            if (model != null && this.ModelState.IsValid )
            {
                model.UserId = this.User.Identity.GetUserId();
                var comment = Mapper.Map<Comment>(model);
                this.Data.Comments.Add(comment);
                this.Data.SaveChanges();

                var commentDt = this.Data.Comments.All()
                    .Where(x => x.Id == comment.Id)
                    .Project().To<CommentsViewModel>().FirstOrDefault();
                return this.PartialView("DisplayTemplates/CommentViewModel", commentDt);
            }
            return this.Json("Error");
        }
    }
}