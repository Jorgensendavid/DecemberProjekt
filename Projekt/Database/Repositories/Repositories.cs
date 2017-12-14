using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entities;

namespace Database
{
    public class Repositories
    {
        DataContext datacontext = new DataContext();
        
        public void addUser(User user)
        {
            datacontext.Users.Add(user);
        }
        public void saveUser()
        {
            datacontext.SaveChanges();
        }

    }
}
