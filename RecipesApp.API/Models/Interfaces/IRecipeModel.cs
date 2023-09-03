namespace RecipesApp.API.Models.Interfaces
{
    public interface IRecipeModel
    {
        string RecipeName { get; set; }
        string Description { get; set; }
        RecipeTypeEnums RecipeType { get; set; }
        string RecipeMaker { get; set; }
    }
}
