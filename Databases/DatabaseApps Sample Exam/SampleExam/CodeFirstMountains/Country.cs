using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstMountains
{
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public Country()
        {
            this.Mountains = new HashSet<Mountain>();
        }

        [StringLength(2)]
        [Key]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Mountain> Mountains { get; set; }


    }
}
