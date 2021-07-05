using CodingDay.Data.DataContexts;
using CodingDay.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDay.Data.Repositories
{
    public class UserRepository
    {
        private readonly SqlDataContext _context;

        public UserRepository(SqlDataContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
