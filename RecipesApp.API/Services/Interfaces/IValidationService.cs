using RecipesApp.DATA.Models;
using RecipesApp.DATA.Entities;

namespace RecipesApp.API.Services.Interfaces
{
    public interface IValidationService
    {
        string ValidateUser(UserModel? model, UserEntity? entity, string? id);
        bool ValidateRecipe(RecipeModel? model, RecipeEntity? entity);
    }
}
