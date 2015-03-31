using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstPhonebook
{
    using System.ComponentModel.DataAnnotations;

    public class Contact
    {

        public Contact()
        {
            this.Emails = new HashSet<Email>();
            this.Phones = new HashSet<Phone>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }
        
        public string Position { get; set; }
        
        public string Company { get; set; }

        public virtual ICollection<Email> Emails { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

        [Url]
        
        public string Url { get; set; }

       
        public string notes { get; set; }

    }
}
