using System;
using System.ComponentModel.DataAnnotations;

namespace Twitter.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        [Required]
        public string OwnerId { get; set; }
        public virtual User OwnerUser { get; set; }
        [Required]
        public string RecipientId { get; set; }
        public virtual User RecipientUser { get; set; } 
    }
}
