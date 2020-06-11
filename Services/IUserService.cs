using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        
        User GetUserById(int id = 0);

        User AddUser(User user);

        User DeleteUser(int id = 0);
    }
}
