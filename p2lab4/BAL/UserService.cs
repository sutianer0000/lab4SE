using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Repositories;

namespace BAL
{
    public class UserService
    {
        private readonly UserRepository _repo;
        public UserService() { _repo = new UserRepository(); }

        public bool ValidateUser(string username, string password)
        {
            return _repo.GetUserByCredentials(username, password) != null;
        }
    }
}