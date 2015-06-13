namespace Bookmarks.Web.InputModels
{
    using System.ComponentModel.DataAnnotations;

    using Bookmarks.Common;
    using Bookmarks.Common.Mappings;
    using Bookmarks.Models;

    public class BookmarkInputModel : IMapTo<Bookmark>
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = GlobalConstants.RequiredValidationMsg)]
        [StringLength(200)]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = GlobalConstants.RequiredValidationMsg)]
        [StringLength(200, ErrorMessage = GlobalConstants.StringLengthValidationMsg)]
        [Url(ErrorMessage = "The {0} is invalid")]
        public string Url { get; set; }

        public string Description { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

    }
}