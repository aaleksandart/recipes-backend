using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using RecipesApp.API.Services.Interfaces;
using RecipesApp.DATA.Models;
using RecipesApp.DATA.Services.Interfaces;

namespace RecipesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IValidationService _validationService;
        public UserController(IUserService userService, IRecipeService recipeService, IValidationService validationService)
        {
            _userService = userService;
            _validationService = validationService;
        }

        [HttpGet]
        public async Task<List<UserModel>> GetUsersAsync() =>
            await _userService.GetAllUsers();

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByIdAsync(string id)
        {
            //Validating id
            var validation = _validationService.ValidateUser(null, null, id);
            if (!string.IsNullOrEmpty(validation))
                return BadRequest();
            //Getting User and returning result
            var result = await _userService.GetUserById(id);
            return (string.IsNullOrEmpty(result.Id) ? NotFound() : Ok(result));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(UserModel user)
        {
            //Validate new user
            var validation = _validationService.ValidateUser(user, null, null);
            if (!string.IsNullOrEmpty(validation))
                return BadRequest(validation);
            //Create user and returning status code result
            return await _userService.CreateUser(user) ? StatusCode(201) : StatusCode(500);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserAsync(UserModel user)
        {
            //Validate user
            var validation = _validationService.ValidateUser(user, null, null);
            if (!string.IsNullOrEmpty(validation))
                return BadRequest(validation);
            //Update user and returning result
            var result = await _userService.UpdateUser(user);
            return (string.IsNullOrEmpty(result.Id) ? StatusCode(500) : Ok(result));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUserAsync(string id)
        {
            //Validating id
            var validation = _validationService.ValidateUser(null, null, id);
            if (!string.IsNullOrEmpty(validation))
                return BadRequest();
            //Deleting user and returning status code result
            return await _userService.DeleteUser(id) ? StatusCode(200) : StatusCode(500);
        }
    }
}
