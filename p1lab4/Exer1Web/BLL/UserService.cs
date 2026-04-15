using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public bool ValidateUser(string username, string password)
        {
            var user = _userRepository.GetUserByCredentials(username, password);
            return user != null;
        }
    }
}
