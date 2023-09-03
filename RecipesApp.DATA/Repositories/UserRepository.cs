using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RecipesApp.DATA.Database;
using RecipesApp.DATA.Entities;
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
    }
}
