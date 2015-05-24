using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Twitter.Web
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Profile
    {
        [Key]
        [ForeignKey("User")]
        public string Id { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
