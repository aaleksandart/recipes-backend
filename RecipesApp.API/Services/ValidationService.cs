using RecipesApp.DATA.Models;
using RecipesApp.API.Services.Interfaces;
using RecipesApp.DATA.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RecipesApp.API.Services
{
    public class ValidationService : IValidationService
    {
        public string ValidateUser(UserModel? model, UserEntity? entity, string? id)
        {
            var idError = "The id provided is not in the correct format.";
            var usernameError = "Username is required and needs to be an valid email address. ";
            var nameError = "Name is required and needs to be at least 2 characters long. ";
            var ageError = "Age is required and needs to be a number.";

            var errorMessage = string.Empty;
            if (model != null)
            {
                errorMessage += (Regex.IsMatch(model.UserName, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) ? string.Empty : usernameError;
                errorMessage += (!string.IsNullOrEmpty(model.Name) && model.Name.Length >= 2) ? string.Empty : nameError;
                errorMessage += (model.Age != 0) ? string.Empty : ageError;
                return errorMessage;
            }
            else if (entity != null)
            {
                errorMessage = (entity.Id.Length == 24) ? string.Empty : idError;
                errorMessage = (Regex.IsMatch(entity.UserName, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ? string.Empty : usernameError);
                errorMessage = (!string.IsNullOrEmpty(entity.Name) && entity.Name.Length < 2) ? string.Empty : nameError;
                errorMessage = (entity.Age != 0) ? string.Empty : ageError;
                return errorMessage;
            }
            else if (id != null)
                return errorMessage = idError;
            return errorMessage = "Validation error.";
        }

        public bool ValidateRecipe(RecipeModel? model, RecipeEntity? entity)
        {
            throw new NotImplementedException();
            if (model != null)
            {

            }
            else
            {

            }
        }
    }
}
