using RecipesApp.DATA.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Models
{
    public class RecipeModel : IRecipeModel
    {
        public string RecipeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RecipeTypeEnums RecipeType { get; set; } = 0;
        public string RecipeMaker { get; set; } = string.Empty;
    }
}
