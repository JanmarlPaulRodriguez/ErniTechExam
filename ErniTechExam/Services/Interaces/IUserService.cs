using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ErniTechExam.Models;

namespace ErniTechExam.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserModel>> GetUsers();
    }
}
