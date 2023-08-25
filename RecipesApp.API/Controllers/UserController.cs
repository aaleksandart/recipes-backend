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
        public async Task<List<UserModel>> GetUsers()
        {
            return new List<UserModel>();
        }

        [HttpGet("{id}")]
        public async Task<UserModel> GetUser(int id)
        {
            return new UserModel();
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(UserModel user)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(UserModel user)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            return Ok();
        }
    }
}
