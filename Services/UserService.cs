using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UserService : IUserService
    {
        private List<User> _users; 

        public UserService()
        {
            _users = new List<User>();

            //initializing dummy users.
            init();
        }

        public User AddUser(User user)
        {
            if (user != null)
            {
               _users.Add(user);
                return user;
            }                
            return null;
        }

        public User DeleteUser(int id = 0)
        {
            if (id != 0)
            {
                var user = GetUserById(id);
                if (user != null)
                {
                    if (_users.Remove(user))
                        return user;
                }                
            }
            return null;
        }

        public List<User> GetAllUsers()
        {
            if (_users.Count > 0)
                return _users;

            return null;
        }

        public User GetUserById(int id)
        {
            foreach (var user in _users)
            {
                if (user.UserId == id)
                {
                    return user;
                }
            }
            return null;
        }


        private void init()
        {
            _users.Add(new User() { UserId = 1, UserName = "avi", Password = "123" });
            _users.Add(new User() { UserId = 2, UserName = "John", Password = "password" });
        }
    }
}
