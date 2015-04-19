//using System.Data;

namespace BugTracker.RestServices.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Web.Http;
    using System.Web.Http.Description;

    using BugTracker.Data;
    using BugTracker.Data.Models;
    using BugTracker.RestServices.Models;

    using Microsoft.AspNet.Identity;

    public class BugsController : ApiController
    {
        private BugTrackerDbContext db = new BugTrackerDbContext();

        // GET: api/Bugs
        public IHttpActionResult GetBugs()
        {
            var bugs =
                this.db.Bugs.OrderByDescending(b => b.SubmitedDate)
                    .ThenByDescending(b => b.Id)
                    .Select(b => new BugsOutputModel
                        {
                            Id = b.Id,
                            Title = b.Title,
                            Status = b.Status.ToString(),
                            Author = b.Author.UserName,
                            DateCreated = b.SubmitedDate

                        });
            return this.Ok(bugs);
        }

        // GET: api/Bugs/5
        [ResponseType(typeof(Bug))]
        public IHttpActionResult GetBug(int id)
        {
            var bugId = this.db.Bugs.Find(id);
            if (bugId == null)
            {
                return this.NotFound();
            }

            var bug = this.db.Bugs.Where(b => b.Id == id).Select(b => new BugsOutputModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    Status = b.Status.ToString(),
                    Author = b.Author.UserName,
                    DateCreated = b.SubmitedDate,
                    Comments = db.Comments.OrderByDescending(c => c.Date)
                        .ThenByDescending(c => c.Id)
                        .Where(c => c.BugId == id)
                        .Select(c => new
                        {
                            Id = c.Id,
                            Text = c.Text,
                            Author = c.Author == null ? null : c.Author.UserName,
                            DateCreated = c.Date
                        })
                });

            return this.Ok(bug);
        }

        // Patch: api/Bugs/5
        [HttpPatch]
        [ResponseType(typeof(void))]
        public IHttpActionResult PatchBug(int id, BugInputModel bugData)
        {
            var bug = this.db.Bugs.Find(id);
            if (bug == null)
            {
                return this.NotFound();
            }

            if (bug.Title != bugData.Title && bugData.Title != null)
            {
                bug.Title = bugData.Title;
            }
            if (bug.Description != bugData.Description && bugData.Title != null)
            {
                bug.Description = bugData.Description;
            } if (bug.Status != bugData.Status && bugData.Title != null)
            {
                bug.Status = bugData.Status;
            }

            bug.SubmitedDate = DateTime.Now;

            
            this.db.SaveChanges();

            return this.Ok(new {Message = "Bug #"+bug.Id+" patched." });
        }

        // POST: api/Bugs
        
        [AllowAnonymous]
        public IHttpActionResult PostBug(BugInputModel bug)
        {
            if (bug == null)
            {
                return this.BadRequest("Missing Bug data.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (this.db.Bugs.Any(b => b.Title == bug.Title))
            {
                return this.Content(HttpStatusCode.Conflict,
                    new { Message = "Duplicated Bug Title: " + bug.Title });
            }
            var currentId = this.User.Identity.GetUserId();
           // var author = this.db.Users.Where(u => u.Id == currentId).Select(u => u.Id).FirstOrDefault();
            var bugData = new Bug()
                {
                     Title = bug.Title,
                     Description = bug.Description != null ? bug.Description : null,
                     AuthorId = currentId,
                     Status = StatusTypes.Open,
                     SubmitedDate = DateTime.Now
                };


            db.Bugs.Add(bugData);
            db.SaveChanges();

            if (currentId == null)
            {
                return this.CreatedAtRoute("DefaultApi",
                new { controller = "BugsController", id = bugData.Id },
                new
                {
                    Id = bugData.Id,
                    Message = "Anonymous bug submitted."

                });
            }
            return this.CreatedAtRoute("DefaultApi",
                new { controller = "BugsController", id = bugData.Id },
                new
                {
                    Id = bugData.Id,
                    Author = User.Identity.GetUserName(),
                    Message = "User bug submitted."

                });
            
            
        }

        // DELETE: api/Bugs/5
        [ResponseType(typeof(Bug))]
        public IHttpActionResult DeleteBug(int id)
        {
            Bug bug = db.Bugs.Find(id);
            if (bug == null)
            {
                return NotFound();
            }

            db.Bugs.Remove(bug);
            db.SaveChanges();

            return Ok(new {Message = "Bug # "+id+" deleted."});
        }
        [Route("bugs/filter")]
        public IHttpActionResult GetBugsByFilter([FromUri]string statuses, [FromUri]string author, [FromUri]string keyword = null)
        {
            throw new NotImplementedException();
        }
    }
}