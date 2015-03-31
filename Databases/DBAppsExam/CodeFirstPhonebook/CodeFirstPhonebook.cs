using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPhonebook
{
    using System.Data.Entity;

    using global::CodeFirstPhonebook.Migrations;

    class CodeFirstPhonebook
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PhoneBookContext, Configuration>());

            var context = new PhoneBookContext();
            var contactsQuery = context.Contacts.Select(c => new
            {
                Name = c.Name,
                Position = c.Position,
                Company = c.Company,
                Emails = c.Emails.Select(e => e.EmailAdresses),
                Phones = c.Phones,
                Url = c.Url,
                Notes = c.notes
            });
            var result = contactsQuery.ToList();
           
        }
    }
}
