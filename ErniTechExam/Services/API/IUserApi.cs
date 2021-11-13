﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ErniTechExam.Models;
using Refit;

namespace ErniTechExam.Services.API
{
    public interface IUserApi
    {
        [Get("/erni-ph-mobile-team/c5b401c4fad718da9038669250baff06/raw/7e390e8aa3f7da4c35b65b493fcbfea3da55eac9/test.json")]
        Task<List<UserModel>> GetUsers();
    }
}
