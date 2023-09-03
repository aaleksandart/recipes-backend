using RecipesApp.API.Models.Interfaces;

namespace RecipesApp.API.Models
{
    public class RecipeModel : IRecipeModel
    {
        public string RecipeName { get ; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RecipeTypeEnums RecipeType { get; set; } = 0;
        public string RecipeMaker { get; set; } = string.Empty;
    }
}
