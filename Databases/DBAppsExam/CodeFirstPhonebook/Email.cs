using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstPhonebook
{
    using System.ComponentModel.DataAnnotations;

    public class Email
    {

        public int Id { get; set; }

        [Required]
        public string EmailAdresses { get; set; }
    }
}
