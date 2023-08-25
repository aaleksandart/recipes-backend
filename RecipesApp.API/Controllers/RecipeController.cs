using Microsoft.AspNetCore.Mvc;
using RecipesApp.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        // GET: api/<RecipeController>
        [HttpGet]
        public async Task<List<RecipeModel>> GetRecipes()
        {
            return new List<RecipeModel>();
        }

        // GET api/<RecipeController>/5
        [HttpGet("{id}")]
        public async Task<RecipeModel> GetRecipe(int id)
        {
            return new RecipeModel();
        }

        // POST api/<RecipeController>
        [HttpPost]
        public async Task<ActionResult> CreateRecipe(RecipeModel recipe)
        {
            return Ok();
        }

        // PUT api/<RecipeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateRecipe(RecipeModel recipe)
        {
            return Ok();
        }

        // DELETE api/<RecipeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRecipe(int id)
        {
            return Ok();
        }
    }
}
