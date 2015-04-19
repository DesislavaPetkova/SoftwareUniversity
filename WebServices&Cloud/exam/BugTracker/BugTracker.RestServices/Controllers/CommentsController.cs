namespace BugTracker.RestServices.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;

    using BugTracker.Data;
    using BugTracker.Data.Models;
    using BugTracker.RestServices.Models;

    using Microsoft.AspNet.Identity;

    [RoutePrefix("api")]
    public class CommentsController : ApiController
    {
        private BugTrackerDbContext db = new BugTrackerDbContext();

        [Route("comments")]
        public IHttpActionResult GetComments()
        {
            var comments = this.db.Comments
                .OrderByDescending(c => c.Date)
                .ThenByDescending(c => c.Id)
                .Select(c => new CommentOutputModel()
                {
                    Id = c.Id,
                    Title = c.Text,
                    Author = c.Author.UserName,
                    DateCreated = c.Date,
                    BugId = c.BugId.ToString(),
                    BugTitle = c.Bug.Title
                });
            return this.Ok(comments);
        }
        [Route("bugs/{id}/comments")]
        public IHttpActionResult GetCommentsforBug(int id)
        {
            var bugId = this.db.Bugs.Find(id);
            if (bugId == null)
            {
                return this.NotFound();
            }
            var comments =
                this.db.Comments.OrderByDescending(c => c.Date)
                    .ThenByDescending(c => c.Id)
                    .Where(c => c.BugId == id)
                    .Select(c => new 
                        {
                            Id = c.Id,
                            Text = c.Text,
                            Author = c.Author.UserName,
                            DateCreated = c.Date
                        });

            return this.Ok(comments);
        }

        [HttpPost]
        [Route("bugs/{id}/comments")]
        public IHttpActionResult PostCommentForBug(int id, CommentInputModel commentData)
        {
            var currentUser = this.User.Identity.GetUserId();
            var bugCheck = this.db.Bugs.Find(id);

            if (bugCheck == null)
            {
                return this.NotFound();
            }
            if (commentData.Text == null || commentData.Text.Length <= 1)
            {
                return this.BadRequest();
            }

            var comment = new Comment()
                {
                    Text = commentData.Text,
                    AuthorId = currentUser,
                    BugId = id,
                    Date = DateTime.Now,
                };
            this.db.Comments.Add(comment);
            this.db.SaveChanges();

            if (currentUser == null)
            {
                return this.Ok(new 
                {
                    Id = comment.Id,
                    Message = "Added anonymous comment for bug #"+ id
                });
            }

            return this.Ok(new
                {
                    Id = comment.Id,
                    Author = User.Identity.GetUserName(), 
                    Message =  "User comment added for bug #"+ id
                });

        }
    }
}
