namespace RecipesApp.API.Models
{
    public class UserModel : IUserModel
    {
        public string UserName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
