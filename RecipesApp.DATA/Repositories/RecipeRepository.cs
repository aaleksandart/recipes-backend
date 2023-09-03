using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RecipesApp.DATA.Database;
using RecipesApp.DATA.Entities;
using RecipesApp.DATA.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IMongoCollection<RecipeEntity> _recipesCollection;
        public RecipeRepository(IOptions<RecipesDatabaseSettings> recipeDatabaseSettings)
        {
            var mongoClient = new MongoClient(recipeDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(recipeDatabaseSettings.Value.DatabaseName);
            _recipesCollection = mongoDatabase.GetCollection<RecipeEntity>(recipeDatabaseSettings.Value.RecipesCollection);
        }
    }
}
