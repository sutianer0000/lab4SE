using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepository
    {
        private readonly Exer1DbContext _context;

        public UserRepository()
        {
            _context = new Exer1DbContext();
        }

        public User GetUserByCredentials(string username, string password)
        {
            return _context.Users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);
        }
    }
}