using RecipesApp.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Services.Interfaces
{
    public interface IUserService
    {
        //Get all users
        Task<List<UserModel>> GetAllUsers();
        //Get user by id
        Task<UserModel> GetUserById(string id);
        //Create new user
        Task<bool> CreateUser(UserModel user);
        //Update user
        Task<UserModel> UpdateUser(UserModel user);
        //Delete user
        Task<bool> DeleteUser(string id);
    }
}
