using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Twitter.Models
{
    public class Profile
    {
        [Key, ForeignKey("User")]
        public string UserId { get; set; }

        public byte[] Image { get; set; }

        public virtual User User { get; set; }

        


    }
}
