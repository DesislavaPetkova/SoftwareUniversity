namespace Twitter.Data
{
    using System.ComponentModel.DataAnnotations;

    public class TweetInputModels
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "The min length is 5 symbols")]
        public string Text { get; set; }

        public string URL { get; set; }
    }
}
