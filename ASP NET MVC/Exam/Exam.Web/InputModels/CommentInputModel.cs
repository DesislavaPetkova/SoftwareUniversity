namespace Exam.Web.InputModels
{
    using Exam.Common.Mappings;
    using Exam.Models;

    public class CommentInputModel : IMapTo<Comment>
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int MatchId { get; set; }
        public string UserId { get; set; }

    }
}