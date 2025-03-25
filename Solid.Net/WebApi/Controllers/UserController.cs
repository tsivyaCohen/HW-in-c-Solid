using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;


        public UserController()
        {
            _userService = new UserService();
        }

        // GET: api/<UserController>
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();  
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User GetById(int id)
        {
            return _userService.GetUserById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post([FromBody] User value)
        {
            return _userService.AddUser(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            _userService.UpdateUser(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            return _userService.DeleteUser(id);
        }
    }
}
