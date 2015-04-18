namespace Messages.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Channel
    {
        public Channel()
        {
            this.ChannelMessages = new HashSet<ChannelMessage>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<ChannelMessage> ChannelMessages { get; set; }
    }
}
