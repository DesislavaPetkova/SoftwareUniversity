﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstMountains
{
    using System.ComponentModel.DataAnnotations;

    public class Mountain
    {
        public Mountain()
        {
            this.Countries = new HashSet<Country>();   
            this.Peaks = new HashSet<Peak>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<Peak> Peaks { get; set; }

    }
}
