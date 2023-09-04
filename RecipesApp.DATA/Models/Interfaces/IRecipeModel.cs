using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Models.Interfaces
{
    public interface IRecipeModel
    {
        string RecipeName { get; set; }
        string Description { get; set; }
        RecipeTypeEnums RecipeType { get; set; }
        string RecipeMaker { get; set; }
    }
}
