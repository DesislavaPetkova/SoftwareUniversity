using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Twitter.Models;

namespace Twitter.Models
{
    
    public class Profile
    {
        [Key]
        [ForeignKey("User")]
        public string Id { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
