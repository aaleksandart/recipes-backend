using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using RecipesApp.DATA.Database;
using RecipesApp.DATA.Entities;
using RecipesApp.DATA.Models;
using RecipesApp.DATA.Repositories.Interfaces;
using RecipesApp.DATA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<UserEntity> _usersCollection;
        public UserRepository(IOptions<RecipesDatabaseSettings> recipeDatabaseSettings)
        {
            var mongoClient = new MongoClient(recipeDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(recipeDatabaseSettings.Value.DatabaseName);
            _usersCollection = mongoDatabase.GetCollection<UserEntity>(recipeDatabaseSettings.Value.UsersCollection);
        }
        
        //Get all users
        public async Task<List<UserEntity>> GetAllUsers() =>
            await _usersCollection.Find(_ => true).ToListAsync();
        //Get user by id
        public async Task<UserEntity> GetUserById(string id) =>
            await _usersCollection.Find(u => u.Id == id).FirstOrDefaultAsync();
        //Create new user
        public async Task CreateUser(UserEntity user) =>
            await _usersCollection.InsertOneAsync(user);
        //Update user
        public async Task<UserEntity> UpdateUser(UserEntity user) =>
            await _usersCollection.FindOneAndReplaceAsync(u => u.Id == user.Id, user);
        //Delete user
        public async Task<UserEntity> DeleteUser(string id) =>
            await _usersCollection.FindOneAndDeleteAsync(u => u.Id == id);
            
    }
}
