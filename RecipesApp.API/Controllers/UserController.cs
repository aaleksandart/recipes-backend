using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.API.Models;

namespace RecipesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<List<UserModel>> GetUsersAsync()
        {
            return new List<UserModel>();
        }

        [HttpGet("{id}")]
        public async Task<UserModel> GetUserByIdAsync(int id)
        {
            return new UserModel();
        }

        [HttpPost]
        public async Task<ActionResult> CreateUserAsync(UserModel user)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUserAsync(UserModel user)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUserAsync(int id)
        {
            return Ok();
        }
    }
}
