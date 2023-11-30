using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserModel> users = new List<UserModel>{
            new UserModel{Id=123, Name="Melina",Password="rahasia",
            FavoriteColor="blue", Role="admin", GoogleId="72200392"}
        };
        public UserModel? GetByGoogleId(string GoogleId)
        {
            throw new NotImplementedException();
        }

        public UserModel? GetByUsernameAndPassword(string Username, string Password)
        {
            var user= users.SingleOrDefault(u=>u.Name == Username && Password=="rahasia");
            return user;
        }
    }
}
       