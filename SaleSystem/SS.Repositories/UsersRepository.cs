using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SS.Model;
using SS.Repositories.Interfaces;

namespace SS.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public List<User> GetUsers () 
        {
            try
            {
                var users = new List<User>();

                using (var connection = new SSModelContainer())
                {
                    users = connection.Users.Where(x => x.Status).ToList();    
                }

                return users;
            }
            catch (Exception ex)
            {
                return new List<User>();
            }
        }   
        



    }
}
