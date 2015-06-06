namespace Twitter.Models
{
    using System.ComponentModel.DataAnnotations;
    

  

    public class Messages
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Content { get; set; }

        public string SenderId { get; set; }

        public virtual User Sender { get; set; }

        public string ReciverId { get; set; }

        public virtual User Reciver { get; set; }

    }
}
