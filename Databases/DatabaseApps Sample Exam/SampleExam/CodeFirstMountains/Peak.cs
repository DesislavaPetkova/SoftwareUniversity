using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstMountains
{
    using System.ComponentModel.DataAnnotations;

    public class Peak
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int Elevation { get; set; }

        public int MountainId { get; set; }

        public virtual Mountain Mountain { get; set; }
    }
}
