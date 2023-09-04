using RecipesApp.DATA.Entities;
using RecipesApp.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserEntity>> GetAllUsers();
        Task<UserEntity> GetUserById(string id);
        Task CreateUser(UserEntity user);
        Task<UserEntity> UpdateUser(UserEntity user);
        Task<UserEntity> DeleteUser(string id);
    }
}
