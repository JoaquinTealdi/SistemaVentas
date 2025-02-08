using SS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        List<User> GetUsers();
    }
}
