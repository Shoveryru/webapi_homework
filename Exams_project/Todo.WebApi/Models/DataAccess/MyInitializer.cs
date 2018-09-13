using System.Data.Entity;
using TODO.WebApi.Models.Entities;

namespace TODO.WebApi.Models.DataAccess
{
    public class MyInitializer : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            context.UserSet.Add(new User
            {
                Id = 1,
                FirstName = "Вася",
                LastName = "Васечкин",
                MiddleName = "Васильевич",
                MobilePhone = "+79271234567",
                Email = "vasya@mail.ru"
            });

            context.UserSet.Add(new User
            {
                Id = 2,
                FirstName = "Петя",
                LastName = "Петечкин",
                MiddleName = "Петрович",
                MobilePhone = "+79271234567",
                Email = "petya@mail.ru"
            });

            context.UserSet.Add(new User
            {
                Id = 3,
                FirstName = "Иван",
                LastName = "Иванович",
                MiddleName = "Иванов",
                MobilePhone = "+79271234567",
                Email = "vanya@mail.ru"
            });

            base.Seed(context);
        }
    }
}