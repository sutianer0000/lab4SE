using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Models;
using System.Linq;

namespace DAL.Repositories
{
    public class UserRepository
    {
        private readonly SchoolDbContext _context;
        public UserRepository() { _context = new SchoolDbContext(); }

        public User GetUserByCredentials(string username, string password)
        {
            return _context.Users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);
        }
    }
}