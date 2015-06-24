using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Player
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime DateofBirth { get; set; }
        [Required]
        public double Height { get; set; }
        
        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
