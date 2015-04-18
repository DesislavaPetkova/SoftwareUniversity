namespace Messages.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserMessage
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime DateSent { get; set; }

        public virtual User Sender { get; set; }
        public string SenderId { get; set; }
        [Required]
        public virtual User Recipient { get; set; }
        [Required]
        public string RecipientId { get; set; }

    }
}
