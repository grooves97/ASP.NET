using System.Collections.Generic;
using System.Data.Entity;
using WebApplication5.Models;

namespace WebApplication5.DataAccess
{
    public class PeopleInitializer : CreateDatabaseIfNotExists<Context>
    {

        protected override void Seed(Context context)
        {
            context.People.AddRange(new List<Person>
            {
                new Person
                {
                    FullName = "Петр Петрович",
                    PhoneNumber = "+7777988555655"
                },
                new Person
                {
                    FullName = "Алёша Попович",
                    PhoneNumber = "+7777988555655"
                },
                new Person
                {
                    FullName = "Гарик Харламов",
                    PhoneNumber = "+7777988555655"
                },
                new Person
                {
                    FullName = "Нурлан Сабуров",
                    PhoneNumber = "+7777988555655"
                }
            });
        }
    }
}