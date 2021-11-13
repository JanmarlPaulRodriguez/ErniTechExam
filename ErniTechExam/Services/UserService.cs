using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErniTechExam.Models;
using ErniTechExam.Services.API;
using ErniTechExam.Services.Interfaces;
using Refit;
using Xamarin.Essentials;

namespace ErniTechExam.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {
        }

        public async Task<List<UserModel>> GetUsers()
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                throw new Exception("You are not connected to the internet!");
            }

            var userApi = RestService.For<IUserApi>("https://gist.githubusercontent.com");
            var users = await userApi.GetUsers();

            // Remove if Items have similiar Ids since this should not be possible
            // in DB.
            return users.GroupBy(x => x.Id).Select(y => y.First()).ToList();
        }
    }
}
