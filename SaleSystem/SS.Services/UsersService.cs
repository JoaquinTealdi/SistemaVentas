using SS.Model;
using SS.Repositories;
using SS.Repositories.Interfaces;
using SS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _repository;

        public UsersService(IUsersRepository repository)
        {
            _repository = repository;
        }

        public List<User> GetUsers()
        {
            try
            {
                return _repository.GetUsers();
            }
            catch (Exception ex)
            {
                return new List<User>();
            }
        }



    }
}
