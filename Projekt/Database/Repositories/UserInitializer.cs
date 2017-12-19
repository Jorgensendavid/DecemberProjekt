using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entities;

namespace Database.Repositories
{
    public class UserInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var user = new User
            {
                Firstname = "Amanda",
                Lastname ="Reimertz",
                Email = "amanda@reimertz.se",
                Password = "123456"
            };

            context.Users.Add(user);

            context.SaveChanges();

            base.Seed(context);
        }

    }
}