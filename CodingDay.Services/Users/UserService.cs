using CodingDay.Data.Repositories;
using CodingDay.Entities.Users;
using System;
using System.Collections.Generic;

namespace CodingDay.Services.Users
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public void CreateUser()
        {
            throw new NotImplementedException();
        }
    }
}
