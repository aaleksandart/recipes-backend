using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Models.Interfaces
{
    public interface IUserModel
    {
        string Id { get; set; }
        string UserName { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
}
