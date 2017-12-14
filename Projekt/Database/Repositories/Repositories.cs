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

        public User GetPassword(string email, string password)
        {
            var user = datacontext.Users.FirstOrDefault(x => x.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                                                         x.Password.Equals(password, StringComparison.OrdinalIgnoreCase));
            return user;
        }
    }
}
