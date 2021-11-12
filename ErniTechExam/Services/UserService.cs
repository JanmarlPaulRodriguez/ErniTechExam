using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ErniTechExam.Models;
using ErniTechExam.Services.Interfaces;

namespace ErniTechExam.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {
        }

        public Task<List<UserModel>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
