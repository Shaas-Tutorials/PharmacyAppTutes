using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _service.GetAllUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            if (id == 0)
                return null;
            return _service.GetUserById(id);
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult<User> Add(User user)
        {
            if (user == null)
                return null;

            return _service.AddUser(user);
        }

        [HttpDelete("{id}")]
        public ActionResult<User> Delete(int id)
        {
            if (id == 0)
                return null;

            return _service.DeleteUser(id);
        }
    }
}