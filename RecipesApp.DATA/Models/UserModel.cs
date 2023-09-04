using RecipesApp.DATA.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Models
{
    public class UserModel : IUserModel
    {
        public UserModel()
        {
        }

        public UserModel(string userName, string name, int age)
        {
            UserName = userName;
            Name = name;
            Age = age;
        }

        public UserModel(string id, string userName, string name, int age)
        {
            Id = id;
            UserName = userName;
            Name = name;
            Age = age;
        }

        public string Id { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
