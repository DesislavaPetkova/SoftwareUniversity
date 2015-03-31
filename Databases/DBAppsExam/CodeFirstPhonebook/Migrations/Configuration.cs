namespace CodeFirstPhonebook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneBookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PhoneBookContext context)
        {
            if (!context.Contacts.Any())
            {
                Phone mariaPhone = new Phone() { PhoneNumber = "+359 22 33 44 55" };
                context.Phones.Add(mariaPhone);
                Phone peterPhone = new Phone() { PhoneNumber = "+359 2 22 22 22" };
                context.Phones.Add(peterPhone);
                Phone peterPhone1 = new Phone() { PhoneNumber = "+359 88 77 88 99" };
                context.Phones.Add(peterPhone1);

                Email angieEmail = new Email() { EmailAdresses = "info@angiestanton.com" };
                context.Emails.Add(angieEmail);

                Email peterEmail = new Email() { EmailAdresses = "peter@gmail.com" };
                context.Emails.Add(peterEmail);
                Email peterIvanov = new Email() { EmailAdresses = "peter_ivanov@yahoo.com" };
                context.Emails.Add(peterIvanov);

                Contact peter = new Contact()
                {
                    Name = "Peter Ivanov",
                    Position = "CTO",
                    Company = "Smart Ideas",
                    Emails = { peterEmail, peterIvanov },
                    Phones = { peterPhone, peterPhone1 },
                    Url = "http://blog.peter.com",
                    notes = "Friend from school"

                };
                context.Contacts.Add(peter);

                Contact maria = new Contact()
                {
                    Name = "Maria",
                    Phones = { mariaPhone }
                };
                context.Contacts.Add(maria);

                Contact angie = new Contact()
                {
                    Name = "Angie Stanton",
                    Emails = { angieEmail },

                    Url = "http://angiestanton.com"
                };
                context.Contacts.Add(angie);


                context.SaveChanges();
            }
        }
    }
}
