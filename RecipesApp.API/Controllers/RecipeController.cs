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
        public async Task<List<RecipeModel>> GetRecipesAsync()
        {
            return new List<RecipeModel>();
        }

        // GET api/<RecipeController>/5
        [HttpGet("{id}")]
        public async Task<RecipeModel> GetRecipeByIdAsync(int id)
        {
            return new RecipeModel();
        }

        // POST api/<RecipeController>
        [HttpPost]
        public async Task<ActionResult> CreateRecipeAsync(RecipeModel recipe)
        {
            return Ok();
        }

        // PUT api/<RecipeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateRecipeAsync(RecipeModel recipe)
        {
            return Ok();
        }

        // DELETE api/<RecipeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRecipeAsync(int id)
        {
            return Ok();
        }
    }
}
