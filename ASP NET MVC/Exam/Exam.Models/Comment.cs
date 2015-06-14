using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        public DateTime DataTime { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int MatchId { get; set; }

        public virtual Match Match { get; set; }
    }
}
